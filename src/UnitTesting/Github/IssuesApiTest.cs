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
					Url = "https://api.github.com/repos/aoancea/github-api/issues/2",
					Labels_Url = "https://api.github.com/repos/aoancea/github-api/issues/2/labels{/name}",
					Comments_Url = "https://api.github.com/repos/aoancea/github-api/issues/2/comments",
					Events_Url = "https://api.github.com/repos/aoancea/github-api/issues/2/events",
					Html_Url = "https://github.com/aoancea/github-api/issues/2",
					Id = 115684392,
					Number = 2,
					Title = "Issue 2"
				},
				new Issue()
				{
					Url = "https://api.github.com/repos/aoancea/github-api/issues/1",
					Labels_Url = "https://api.github.com/repos/aoancea/github-api/issues/1/labels{/name}",
					Comments_Url = "https://api.github.com/repos/aoancea/github-api/issues/1/comments",
					Events_Url = "https://api.github.com/repos/aoancea/github-api/issues/1/events",
					Html_Url = "https://github.com/aoancea/github-api/issues/1",
					Id = 115684374,
					Number = 1,
					Title = "Issue 1"
				},
			};

			List<Issue> issues = issuesApi.GetAsync("aoancea", "github-api").Result.ToList();

			Assert.AreEqual(2, issues.Count);
			AssertHaveEqualState(expectedIssues[0], issues[0]);
			AssertHaveEqualState(expectedIssues[1], issues[1]);
		}

		public void AssertHaveEqualState(Issue expected, Issue actual)
		{
			Assert.AreEqual(expected.Url, actual.Url);
			Assert.AreEqual(expected.Labels_Url, actual.Labels_Url);
			Assert.AreEqual(expected.Comments_Url, actual.Comments_Url);
			Assert.AreEqual(expected.Events_Url, actual.Events_Url);
			Assert.AreEqual(expected.Html_Url, actual.Html_Url);
			Assert.AreEqual(expected.Id, actual.Id);
			Assert.AreEqual(expected.Number, actual.Number);
			Assert.AreEqual(expected.Title, actual.Title);
		}
	}
}