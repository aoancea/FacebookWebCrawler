using Crawler.Github.Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crawler.Github.Api
{
	class EventsApi
	{
		private readonly GithubContext githubContext;

		public EventsApi(GithubContext githubContext)
		{
			this.githubContext = githubContext;
		}

		public List<GitEvent> Get(Issue issue)
		{
			return GetAsync(issue).Result;
		}

		public async Task<List<GitEvent>> GetAsync(Issue issue)
		{
			return await githubContext.RequestAsync<List<GitEvent>>(issue.Events_Url);

		}
	}
}
