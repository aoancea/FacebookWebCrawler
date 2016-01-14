using Crawler.Github.Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Crawler.Github.Api
{
	public class CommitsApi
	{
		private readonly GithubContext githubContext;
		private readonly EventsApi eventsApi;

		public CommitsApi(GithubContext githubContext)
		{
			this.githubContext = githubContext;

			this.eventsApi = new EventsApi(githubContext);
		}

		public List<GitCommit> Get(Issue issue)
		{
			return GetAsync(issue).Result;
		}

		public async Task<List<GitCommit>> GetAsync(Issue issue)
		{
			List<GitEvent> events = await eventsApi.GetAsync(issue);

			List<GitCommit> commits = new List<GitCommit>();
			foreach (GitEvent ev in events)
			{
				if ((ev.Event == "referenced" || ev.Event == "closed") && ev.Commit_Url != null)
				{
					try
					{
						commits.Add(await githubContext.RequestAsync<GitCommit>(ev.Commit_Url));
					}
					catch (WebException)
					{
						continue;
					}
				}
			}

			return commits;
		}
	}
}
