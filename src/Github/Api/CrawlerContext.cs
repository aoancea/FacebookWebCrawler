using ServiceStack.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Crawler.Github.Api
{
	public class CrawlerContext : Core.Common.Crawler
	{
		public CrawlerContext()
		{

		}

		protected override bool Authenticate()
		{
			return base.Authenticate();
		}

		public async Task<T> RequestAsync<T>(string path)
		{
			return await RequestAsync<T>(new Uri(path));
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


			var version = "0.1";

			request.UserAgent = "Crawler.Github.Api" + version;

			return request;
		}
	}
}