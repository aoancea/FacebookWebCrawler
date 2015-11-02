using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Crawler.Core.Common
{
	public class CrawlerQueryResult
	{
		private string rawResult;
		private JObject parsedJson;

		public string RawResult
		{
			get
			{
				return this.rawResult;
			}
			set
			{
				this.rawResult = value;
				parsedJson = JObject.Parse(this.rawResult);
			}
		}

		public IEnumerable<string> GetField(string fieldName)
		{
			return parsedJson.SelectTokens(fieldName).Select(x => x.ToString());
		}

		public IEnumerable<JToken> GetFieldToken(string fieldName)
		{
			return parsedJson.SelectTokens(fieldName);
		}

		public string GetSingleField(string fieldName)
		{
			JToken fieldData = parsedJson.SelectToken(fieldName);
			return fieldData != null ? fieldData.ToString() : null;
		}
	}
}