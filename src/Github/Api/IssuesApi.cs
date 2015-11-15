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

		public async Task<List<Issue>> GetAsync(string owner, string repo)
		{
			Uri uri = new Uri(string.Format("https://api.github.com/repos/{0}/{1}/issues", owner, repo));

			return await context.RequestAsync<List<Issue>>(uri);
		}
	}
}