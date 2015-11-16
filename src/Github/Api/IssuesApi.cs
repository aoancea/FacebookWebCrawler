﻿using Crawler.Core.Common.Extensions;
using Crawler.Github.Api.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Crawler.Github.Api
{
	public class IssuesApi
	{
		private readonly GithubContext githubContext;

		public IssuesApi(GithubContext githubContext)
		{
			this.githubContext = githubContext;
		}

		public async Task<List<Issue>> GetAsync(string owner, string repo, Dictionary<string, string> queryString = null)
		{
			Uri uri = new Uri(string.Format("https://api.github.com/repos/{0}/{1}/issues{2}", owner, repo, queryString.ToQueryString()));

			return await githubContext.RequestAsync<List<Issue>>(uri);
		}
	}
}