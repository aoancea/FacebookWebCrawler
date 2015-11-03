using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Crawler.UnitTesting.Github
{
	[TestClass]
	public class CrawlerContextTest
	{
		[TestMethod]
		public void CrawlerContext_Authentication_Success()
		{
			Crawler.Github.Api.CrawlerContext crawler = new Crawler.Github.Api.CrawlerContext();

			Assert.AreEqual(true, crawler.Authenticated);
		}
	}
}