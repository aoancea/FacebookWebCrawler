using System;
using System.Collections.Generic;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ServiceStack.Text;
using Crawler.Core.Common.Queue;

namespace Crawler.Github.Api
{
    public class GithubContext
	{
		private ManagedQueue<string> accessTokens;

		public string RequestsRemaining { get; private set; }

		public int CountTokens { get { return accessTokens.Count; } }

		public GithubContext(IEnumerable<string> accessTokens)
		{
			this.accessTokens = new ManagedQueue<string>(accessTokens);
		}

		public T Request<T>(string path)
		{
			return Request<T>(new Uri(path));
		}

		public T Request<T>(Uri uri)
		{
			HttpWebResponse response = WebRequestResponse(uri);

			T result = JsonSerializer.DeserializeResponse<T>(response);
			RequestsRemaining = response.Headers.Get("X-RateLimit-Remaining");

			return result;
		}

		public async Task<T> RequestAsync<T>(string path)
		{
			return await RequestAsync<T>(new Uri(path));
		}

		public async Task<T> RequestAsync<T>(Uri uri)
		{
			HttpWebResponse response = await WebRequestResponseAsync(uri);
			
			T result = JsonSerializer.DeserializeResponse<T>(response);
			RequestsRemaining = response.Headers.Get("X-RateLimit-Remaining");
			
			return result;
		}

		public async Task<int> GetNumPagesAsync(Uri uri)
		{
			HttpWebResponse response = await WebRequestResponseAsync(uri);

			Regex regex = new Regex(@".*rel=""next"".*page=(\d+)&state=(all|open|closed).*>; rel=""last""", RegexOptions.RightToLeft);
			Match match = regex.Match(response.Headers.Get("Link"));

			return int.Parse(match.Groups[1].Value);
		}

		private HttpWebResponse WebRequestResponse(Uri uri)
		{
			string accessToken = new string(accessTokens.Front.ToCharArray());
			WebRequest request = CreateRequest(uri, accessToken);

			HttpWebResponse response = null;
			try
			{
				response = (HttpWebResponse)request.GetResponse();
			}
			catch (WebException wex)
			{
				if (wex.Status == WebExceptionStatus.Timeout)
				{
					return WebRequestResponse(uri);
				}

				accessTokens.Dequeue(accessToken);
				request = CreateRequest(uri, accessTokens.Front);
				response = (HttpWebResponse)request.GetResponse();
			}

			return response;
		}

		private async Task<HttpWebResponse> WebRequestResponseAsync(Uri uri)
		{
			string accessToken = new string(accessTokens.Front.ToCharArray());
			WebRequest request = CreateRequest(uri, accessToken);

			HttpWebResponse response = null;
			try
			{
				response = (HttpWebResponse)await request.GetResponseAsync().ConfigureAwait(false);
			}
			catch (WebException)
			{
				accessTokens.Dequeue(accessToken);
				request = CreateRequest(uri, accessTokens.Front);
				response = (HttpWebResponse)await request.GetResponseAsync().ConfigureAwait(false);
			}

			return response;
		}

		private WebRequest CreateRequest(Uri uri, string accessToken)
		{
			var request = WebRequest.CreateHttp(uri);
			request.KeepAlive = false;
			request.UserAgent = "Crawler.Github.Api 0.1";

			if (!string.IsNullOrWhiteSpace(accessToken))
				request.Headers["Authorization"] = "token " + accessToken;

			return request;
		}
	}
}