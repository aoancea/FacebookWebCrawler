using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Crawler.Github.Api;
using Crawler.Github.Api.Entities;
using System.Collections.Generic;

namespace Crawler.UnitTesting.Github
{
	[TestClass]
	public class IssuesApiTest
	{
		[TestMethod]
		public async void TestMethod1()
		{
			CrawlerContext context = new CrawlerContext();

			IssuesApi issuesApi = new IssuesApi(context);

			Issue[] issues = (Issue[])await issuesApi.Get();
		}
	}
}
