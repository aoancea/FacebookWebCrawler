using ServiceStack.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Crawler.Github.Api
{
	public class GithubContext
	{
		private object lockerTokenChange = new object();
		private object lockerRequestsUpdate = new object();

		private Queue<string> accessTokens;

		public string Access_Token { get; private set; }

		public string RequestsRemaining { get; private set; }

		public GithubContext(Queue<string> accessTokens)
		{
			this.accessTokens = accessTokens;
			Access_Token = accessTokens.Dequeue();
		}

		public async Task<T> RequestAsync<T>(string path)
		{
			return await RequestAsync<T>(new Uri(path));
		}

		public async Task<int> GetNumPages(Uri uri)
		{
			WebRequest request = CreateRequest(uri);

			HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync().ConfigureAwait(false);

			Regex regex = new Regex(@"page=(\d+)&state=(all|open|closed)>; rel=""last""");
			Match match = regex.Match(response.Headers.Get("Link"));

			return int.Parse(match.Groups[1].Value);
		}

		public async Task<T> RequestAsync<T>(Uri uri)
		{
			WebRequest request = CreateRequest(uri);
			HttpWebResponse response = null;
			T result = default(T);

			try
			{
				response = (HttpWebResponse)await request.GetResponseAsync().ConfigureAwait(false);
			}
			catch (WebException)
			{
				lock (lockerTokenChange)
				{
					if (RequestsRemaining == "0")
					{
						RequestsRemaining = "5000";
						Access_Token = accessTokens.Dequeue();
					}
				}

				request = CreateRequest(uri);
				response = (HttpWebResponse)await request.GetResponseAsync().ConfigureAwait(false);
			}
			finally
			{
				result = JsonSerializer.DeserializeResponse<T>(response);

				lock (lockerRequestsUpdate)
				{
					RequestsRemaining = response.Headers.Get("X-RateLimit-Remaining");
				}

			//	if (int.Parse(RequestsRemaining) <= 1)
			//	{
			//		Access_Token = accessTokens.Dequeue();
			//	}
			}

			return await Task.FromResult<T>(result);

		}

		private WebRequest CreateRequest(Uri uri)
		{
			var request = WebRequest.CreateHttp(uri);
			request.KeepAlive = false;
			request.UserAgent = "Crawler.Github.Api 0.1";

			if (!string.IsNullOrWhiteSpace(Access_Token))
				request.Headers["Authorization"] = "token " + Access_Token;

			return request;
		}
	}
}