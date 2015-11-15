using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Crawler.Github.Api;
using Crawler.Github.Api.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Crawler.UnitTesting.Github
{
	[TestClass]
	public class IssuesApiTest
	{
		private IssuesApi issuesApi;

		[TestInitialize]
		public void TestInitialize()
		{
			CrawlerContext context = new CrawlerContext();

			issuesApi = new IssuesApi(context);
		}

		[TestMethod]
		public void TestMethod1()
		{
			List<Issue> expectedIssues = new List<Issue>()
			{
				new Issue()
				{
					Url = "https://api.github.com/repos/aoancea/github-api-tests/issues/2",
					Labels_Url = "https://api.github.com/repos/aoancea/github-api-tests/issues/2/labels{/name}",
					Comments_Url = "https://api.github.com/repos/aoancea/github-api-tests/issues/2/comments",
					Events_Url = "https://api.github.com/repos/aoancea/github-api-tests/issues/2/events",
					Html_Url = "https://github.com/aoancea/github-api-tests/issues/2",
					Id = 115684392,
					Number = 2,
					Title = "Issue 2",
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
					Labels = new List<Label>()
					{
						new Label()
						{
							Url = "https://api.github.com/repos/aoancea/github-api-tests/labels/enhancement",
							Name = "enhancement",
							Color = "84b6eb"
						}
					},
					State = "open",
					Locked = false,
					Assignee = null,
					Milestone = null,
					Comments = 0,
					Created_at = new DateTime(2015, 11, 07, 20, 43, 25), // there might be a GMT conversion problem as the time fetched comes in local time
					Updated_at = new DateTime(2015, 11, 07, 20, 44, 17), // there might be a GMT conversion problem as the time fetched comes in local time
					Closed_at = null,
					Body = "This is issue 2."
				},
				new Issue()
				{
					Url = "https://api.github.com/repos/aoancea/github-api-tests/issues/1",
					Labels_Url = "https://api.github.com/repos/aoancea/github-api-tests/issues/1/labels{/name}",
					Comments_Url = "https://api.github.com/repos/aoancea/github-api-tests/issues/1/comments",
					Events_Url = "https://api.github.com/repos/aoancea/github-api-tests/issues/1/events",
					Html_Url = "https://github.com/aoancea/github-api-tests/issues/1",
					Id = 115684374,
					Number = 1,
					Title = "Issue 1",
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
					Labels = new List<Label>()
					{
						new Label()
						{
							Url = "https://api.github.com/repos/aoancea/github-api-tests/labels/bug",
							Name = "bug",
							Color = "fc2929"
						}
					},
					State = "open",
					Locked = false,
					Assignee = new User()
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
					Milestone = new Milestone() { }, // TODO: test
					Comments = 2,
					Created_at = new DateTime(2015, 11, 07, 20, 42, 49), // there might be a GMT conversion problem as the time fetched comes in local time
					Updated_at = new DateTime(2015, 11, 07, 20, 49, 18), // there might be a GMT conversion problem as the time fetched comes in local time
					Closed_at = null,
					Body = "This is issue 1."
				},
			};

			List<Issue> issues = issuesApi.GetAsync("aoancea", "github-api-tests").Result.ToList();

			Assert.AreEqual(2, issues.Count);
			AssertAreEqual(expectedIssues[0], issues[0]);
			AssertAreEqual(expectedIssues[1], issues[1]);
		}

		public void AssertAreEqual(Issue expected, Issue actual)
		{
			Assert.AreEqual(expected.Url, actual.Url);
			Assert.AreEqual(expected.Labels_Url, actual.Labels_Url);
			Assert.AreEqual(expected.Comments_Url, actual.Comments_Url);
			Assert.AreEqual(expected.Events_Url, actual.Events_Url);
			Assert.AreEqual(expected.Html_Url, actual.Html_Url);
			Assert.AreEqual(expected.Id, actual.Id);
			Assert.AreEqual(expected.Number, actual.Number);
			Assert.AreEqual(expected.Title, actual.Title);
			AssertAreEqual(expected.User, actual.User);
			AssertAreEqual(expected.Labels, actual.Labels);
			Assert.AreEqual(expected.State, actual.State);
			Assert.AreEqual(expected.Locked, actual.Locked);
			AssertAreEqual(expected.Assignee, actual.Assignee);
			AssertAreEqual(expected.Milestone, actual.Milestone);
			Assert.AreEqual(expected.Comments, actual.Comments);
			Assert.AreEqual(expected.Created_at, actual.Created_at);
			Assert.AreEqual(expected.Updated_at, actual.Updated_at);
			Assert.AreEqual(expected.Closed_at, actual.Closed_at);
			Assert.AreEqual(expected.Body, actual.Body);
		}

		public void AssertAreEqual(User expected, User actual)
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

		public void AssertAreEqual(Milestone expected, Milestone actual)
		{
			if (expected != null || actual != null)
			{
				// TODO: test
			}
			else
			{
				Assert.IsNull(expected);
				Assert.IsNull(actual);
			}
		}

		public void AssertAreEqual(List<Label> expected, List<Label> actual)
		{
			Assert.AreEqual(expected.Count, actual.Count);
			for (int i = 0; i < expected.Count; ++i)
			{
				AssertAreEqual(expected[i], actual[i]);
			}
		}

		public void AssertAreEqual(Label expected, Label actual)
		{
			if (expected != null || actual != null)
			{
				Assert.AreEqual(expected.Url, actual.Url);
				Assert.AreEqual(expected.Name, actual.Name);
				Assert.AreEqual(expected.Color, actual.Color);
			}
			else
			{
				Assert.IsNull(expected);
				Assert.IsNull(actual);
			}
		}
	}
}