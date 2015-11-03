using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Crawler.UnitTesting.Github
{
	[TestClass]
	public class CrawlerTest
	{
		[TestMethod]
		public void Crawler_Authentication_Success()
		{
			Crawler.Github.Api.Crawler crawler = new Crawler.Github.Api.Crawler();

			Assert.AreEqual(true, crawler.Authenticated);
		}
	}
}