using Crawler.Github.Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crawler.Github.Api
{
	public class CommentsApi
	{
		private readonly GithubContext githubContext;

		public CommentsApi(GithubContext githubContext)
		{
			this.githubContext = githubContext;
		}

		public async Task<List<Comment>> GetAsync(Issue issue)
		{
			if (issue.Comments > 0)
				return await githubContext.RequestAsync<List<Comment>>(issue.Comments_Url);

			return await Task.FromResult<List<Comment>>(new List<Comment>(0));
		}
	}
}