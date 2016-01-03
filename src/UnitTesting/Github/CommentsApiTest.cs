using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Crawler.Github.Api;
using Crawler.Github.Api.Entities;
using System.Collections.Generic;

namespace Crawler.UnitTesting.Github
{
	[TestClass]
	public class CommentsApiTest
	{
		private CommentsApi commentsApi;

		[TestInitialize]
		public void TestInitialize()
		{
			Queue<string> queue = new Queue<string>(new string[] { "first" });

			GithubContext context = new GithubContext(queue);

			commentsApi = new CommentsApi(context);
		}

		[TestMethod]
		public void CommentsApi_GetAsync_IssueWithNoComments_ReturnsNoComments()
		{
			Issue issues = new Issue()
			{
				Comments_Url = "https://api.github.com/repos/aoancea/github-api-tests/issues/2/comments",
				Comments = 0,
			};

			List<Comment> comments = commentsApi.GetAsync(issues).Result;

			Assert.AreEqual(0, comments.Count);
		}

		[TestMethod]
		public void CommentsApi_GetAsync_IssueWithComments_ReturnsComments()
		{
			Issue issues = new Issue()
			{
				Comments_Url = "https://api.github.com/repos/aoancea/github-api-tests/issues/1/comments",
				Comments = 2,
			};

			List<Comment> expectedComments = new List<Comment>()
			{
				new Comment()
				{
					Url = "https://api.github.com/repos/aoancea/github-api-tests/issues/comments/154736555",
					Html_Url = "https://github.com/aoancea/github-api-tests/issues/1#issuecomment-154736555",
					Issue_Url = "https://api.github.com/repos/aoancea/github-api-tests/issues/1",
					Id = 154736555,
					User = new User()
					{
						Login = "aoancea",
						Id = 4282532,
						Avatar_Url = "https://avatars.githubusercontent.com/u/4282532?v=3",
						Gravatar_Id = "",
						Url = "https://api.github.com/users/aoancea",
						Html_Url = "https://github.com/aoancea",
						Followers_Url = "https://api.github.com/users/aoancea/followers",
						Following_Url = "https://api.github.com/users/aoancea/following{/other_user}",
						Gists_Url = "https://api.github.com/users/aoancea/gists{/gist_id}"
					}, // TODO: test
					Created_At = new DateTime(2015, 11, 07, 20, 44, 54), // there might be a GMT conversion problem as the time fetched comes in local time
					Updated_At = new DateTime(2015, 11, 07, 20, 44, 54), // there might be a GMT conversion problem as the time fetched comes in local time
					Body = "Comment 1"
				},
				new Comment()
				{
					Url = "https://api.github.com/repos/aoancea/github-api-tests/issues/comments/154736560",
					Html_Url = "https://github.com/aoancea/github-api-tests/issues/1#issuecomment-154736560",
					Issue_Url = "https://api.github.com/repos/aoancea/github-api-tests/issues/1",
					Id = 154736560,
					User = new User()
					{
						Login = "aoancea",
						Id = 4282532,
						Avatar_Url = "https://avatars.githubusercontent.com/u/4282532?v=3",
						Gravatar_Id = "",
						Url = "https://api.github.com/users/aoancea",
						Html_Url = "https://github.com/aoancea",
						Followers_Url = "https://api.github.com/users/aoancea/followers",
						Following_Url = "https://api.github.com/users/aoancea/following{/other_user}",
						Gists_Url = "https://api.github.com/users/aoancea/gists{/gist_id}"
					}, // TODO: test
					Created_At = new DateTime(2015, 11, 07, 20, 44, 58), // there might be a GMT conversion problem as the time fetched comes in local time
					Updated_At = new DateTime(2015, 11, 07, 20, 44, 58), // there might be a GMT conversion problem as the time fetched comes in local time
					Body = "Comment 2"
				},
			};

			List<Comment> comments = commentsApi.GetAsync(issues).Result;

			Assert.AreEqual(issues.Comments, comments.Count);
			AssertAreEqual(expectedComments[0], comments[0]);
			AssertAreEqual(expectedComments[1], comments[1]);
		}


		private void AssertAreEqual(Comment expected, Comment actual)
		{
			Assert.AreEqual(expected.Url, actual.Url);
			Assert.AreEqual(expected.Html_Url, actual.Html_Url);
			Assert.AreEqual(expected.Issue_Url, actual.Issue_Url);
			AssertAreEqual(expected.User, actual.User);
			Assert.AreEqual(expected.Created_At, actual.Created_At);
			Assert.AreEqual(expected.Updated_At, actual.Updated_At);
			Assert.AreEqual(expected.Body, actual.Body);
		}

		private void AssertAreEqual(User expected, User actual)
		{
			if (expected != null || actual != null)
			{
				Assert.AreEqual(expected.Login, actual.Login);
				Assert.AreEqual(expected.Id, actual.Id);
				Assert.AreEqual(expected.Avatar_Url, actual.Avatar_Url);
				Assert.AreEqual(expected.Gravatar_Id, actual.Gravatar_Id);
				Assert.AreEqual(expected.Url, actual.Url);
				Assert.AreEqual(expected.Html_Url, actual.Html_Url);
				Assert.AreEqual(expected.Followers_Url, actual.Followers_Url);
				Assert.AreEqual(expected.Following_Url, actual.Following_Url);
				Assert.AreEqual(expected.Gists_Url, actual.Gists_Url);

				// TODO: test
			}
			else
			{
				Assert.IsNull(expected);
				Assert.IsNull(actual);
			}
		}
	}
}