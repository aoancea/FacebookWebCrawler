using System.Collections.Generic;
using System.Threading.Tasks;
using Crawler.Github.Api.Entities;

namespace Crawler.Github.Api
{
    public class CommentsApi
	{
		private readonly GithubContext githubContext;

		public CommentsApi(GithubContext githubContext)
		{
			this.githubContext = githubContext;
		}

		public List<Comment> Get(Issue issue)
		{
			if (issue.Comments > 0)
				return githubContext.Request<List<Comment>>(issue.Comments_Url);

			return new List<Comment>();
		}

		public async Task<List<Comment>> GetAsync(Issue issue)
		{
			if (issue.Comments > 0)
				return await githubContext.RequestAsync<List<Comment>>(issue.Comments_Url);

            return new List<Comment>();
        }
	}
}