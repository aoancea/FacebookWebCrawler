using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FBCrawlLib
{
    public partial class Crawler
    {
		private const string QUERY_BASE_PATH = "https://graph.facebook.com/v2.2/";

		/// <summary>
		/// Builds a crawler objects.
		/// </summary>
		/// <param name="accessToken">The access token to use with the Facebook Graph API.</param>
		public Crawler(string accessToken = "")
		{
			this.AccessToken = accessToken;
		}

		/// <summary>
		/// Executes a given query using the Facebook Graph API.
		/// </summary>
		/// <param name="query">The query to execute. This will be appended to https://graph.facebook.com/v2.2/ </param>
		/// <returns>A CrawlerQueryResult object which can be used to retrieve various results.</returns>
		public async Task<CrawlerQueryResult> ExecuteQuery(string query)
		{
			string queryPath = Crawler.QUERY_BASE_PATH + query + "?access_token=" + this.AccessToken;

			CrawlerQueryResult result = new CrawlerQueryResult();
			WebClient client = new WebClient();
			
			result.RawResult = await client.DownloadStringTaskAsync(queryPath);

			return result;
		}

		#region Properties
		/// <summary>
		/// Gets or sets the access token to use with the FB API.
		/// </summary>
		public string AccessToken
		{
			get;
			set;
		}
		#endregion
	}
}
