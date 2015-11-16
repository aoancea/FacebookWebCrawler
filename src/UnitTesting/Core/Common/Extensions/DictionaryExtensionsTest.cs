using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Crawler.Core.Common.Extensions;

namespace Crawler.UnitTesting.Core.Common.Extensions
{
	[TestClass]
	public class DictionaryExtensionsTest
	{
		[TestMethod]
		public void DictionaryExtensions_ToQueryString_MissingInput_ReturnsNull()
		{
			Dictionary<string, string> query = null;

			string queryString = query.ToQueryString();

			Assert.IsNull(queryString);
		}

		[TestMethod]
		public void DictionaryExtensions_ToQueryString_OneParameter_ReturnsQueryString()
		{
			Dictionary<string, string> query = new Dictionary<string, string> { { "key1", "value1" } };

			string queryString = query.ToQueryString();

			Assert.AreEqual("?key1=value1", queryString);
		}

		[TestMethod]
		public void DictionaryExtensions_ToQueryString_MultipleParameters_ReturnsQueryString()
		{
			Dictionary<string, string> query = new Dictionary<string, string>
			{
				{ "key1", "value1" },
				{ "key2", "value2" },
				{ "key3", "value3" },
				{ "key4", "value4" },
				{ "key5", "value5" },
			};

			string queryString = query.ToQueryString();

			Assert.AreEqual("?key1=value1&key2=value2&key3=value3&key4=value4&key5=value5", queryString);
		}
	}
}