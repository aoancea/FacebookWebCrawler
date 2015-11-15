using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Crawler.UnitTesting.Github
{
	[TestClass]
	public class GithubContextTest
	{
		[TestMethod]
		public void GithubContext_NewInstance_Success()
		{
			Crawler.Github.Api.GithubContext crawler = new Crawler.Github.Api.GithubContext();

			Assert.IsNotNull(crawler);
		}
	}
}