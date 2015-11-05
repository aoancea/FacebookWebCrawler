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
		[TestMethod]
		public void TestMethod1()
		{
			CrawlerContext context = new CrawlerContext();

			IssuesApi issuesApi = new IssuesApi(context);

			Issue[] issues = issuesApi.GetAsync("aoancea", "FacebookWebCrawler").Result.ToArray();
		}
	}
}
