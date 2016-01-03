using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Crawler.UnitTesting.Github
{
	[TestClass]
	public class GithubContextTest
	{
		[TestMethod]
		public void GithubContext_NewInstance_Success()
		{
			Queue<string> queue = new Queue<string>(new string[] { "first" });

			Crawler.Github.Api.GithubContext crawler = new Crawler.Github.Api.GithubContext(queue);

			Assert.IsNotNull(crawler);
		}
	}
}