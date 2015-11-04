using Crawler.Github.Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crawler.Github.Api
{
	public class IssuesApi
	{
		private readonly CrawlerContext context;

		public IssuesApi(CrawlerContext context)
		{
			this.context = context;
		}

		public async Task<IEnumerable<Issue>> Get(string owner, string repo)
		{
			return await context.RequestAsync<IEnumerable<Issue>>(string.Format("/repos/{0}/{1}/issues", owner, repo));
		}
	}
}
