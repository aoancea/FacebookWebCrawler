using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crawler.Github.Api
{
	public class GithubApi
	{
		private readonly GithubContext githubContext;

		public GithubApi(GithubContext githubContext)
		{
			this.githubContext = githubContext;
		}


		private IssuesApi issuesApi;
		public IssuesApi IssuesApi
		{
			get { return issuesApi ?? (issuesApi = new IssuesApi(githubContext)); }
		}

		private CommentsApi commentsApi;
		public CommentsApi CommentsApi
		{
			get { return commentsApi ?? (commentsApi = new CommentsApi(githubContext)); }
		}

	}
}