using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Crawler.Core.Common
{
	public class Crawler
	{
		public Crawler()
		{
			Authenticate();
		}

		public async Task<CrawlerQueryResult> ExecuteQueryAsync(string query)
		{
			//string queryPath = Crawler.QUERY_BASE_PATH + query + "/feed";
			//if (queryPath.Contains('?'))
			//{
			//	queryPath += "&access_token=" + this.AccessToken;
			//}
			//else
			//{
			//	queryPath += "?access_token=" + this.AccessToken;
			//}

			string queryPath = string.Empty;

			CrawlerQueryResult result = new CrawlerQueryResult();
			WebClient client = new WebClient();

			result.RawResult = await client.DownloadStringTaskAsync(queryPath);

			return result;
		}






		public virtual void Authenticate()
		{

		}

		public virtual string GetUri()
		{
			return string.Empty;
		}
	}
}