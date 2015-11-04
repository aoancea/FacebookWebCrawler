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
			WebRequest request = CreateRequest(path);



			return await Task.FromResult<T>(default(T));
		}






		public WebRequest CreateRequest(string path)
		{
			var uriString = "https://" + "api.github.com" + path;

			var uri = new Uri(uriString);
			var request = WebRequest.CreateHttp(uri);
			request.KeepAlive = false;

			return request;
		}
	}
}