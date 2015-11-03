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


		private bool authenticated;

		public bool Authenticated
		{
			get
			{
				if (!authenticated)
					authenticated = Authenticate();

				return this.authenticated;
			}
			private set
			{
				this.authenticated = true;
			}
		}


		protected virtual bool Authenticate()
		{
			return true;
		}

		protected virtual string GetUri()
		{
			return string.Empty;
		}
	}
}