using ServiceStack.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Crawler.Github.Api
{
	public class GithubContext
	{
		public string Access_Token { get; private set; }

		public GithubContext(string access_token = null)
		{
			Access_Token = access_token;
		}

		public async Task<T> RequestAsync<T>(string path)
		{
			return await RequestAsync<T>(new Uri(path));
		}

		public async Task<int> GetNumPages(Uri uri)
		{
			WebRequest request = CreateRequest(uri);

			HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync().ConfigureAwait(false);

			Regex regex = new Regex(@"page=(\d+)>; rel=""last""");
			Match match = regex.Match(response.Headers.Get("Link"));

			return int.Parse(match.Groups[1].Value);
		}

		public async Task<T> RequestAsync<T>(Uri uri)
		{
			WebRequest request = CreateRequest(uri);

			HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync().ConfigureAwait(false);
			T result = JsonSerializer.DeserializeResponse<T>(response);
			
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