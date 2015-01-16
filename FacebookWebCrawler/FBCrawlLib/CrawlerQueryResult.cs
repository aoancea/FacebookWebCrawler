using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FBCrawlLib
{
	public partial class Crawler
	{
		public class CrawlerQueryResult
		{
			private string _rawResult;
			private JObject _parsedJson;
			/// <summary>
			/// Gets the raw query result.
			/// </summary>
			public string RawResult
			{
				get
				{
					return this._rawResult;
				}
				internal set
				{
					this._rawResult = value;
					_parsedJson = JObject.Parse(this._rawResult);
				}
			}
			
			/// <summary>
			/// Gets an enumerable with the values for a given field name.
			/// </summary>
			/// <param name="fieldName">The field name for which to return values - can be an XPath-like query: data[*].Message.</param>
			/// <returns></returns>
			public IEnumerable<string> GetField(string fieldName)
			{
				return _parsedJson.SelectTokens(fieldName).Select(x => x.ToString());
			}

			/// <summary>
			/// Gets an enumerable with the values for a given field name as JTokens.
			/// </summary>
			/// <param name="fieldName">The field name for which to return values - can be an XPath-like query: data[*].Message.</param>
			/// <returns></returns>
			public IEnumerable<JToken> GetFieldToken(string fieldName)
			{
				return _parsedJson.SelectTokens(fieldName);
			}

			/// <summary>
			/// Gets a field as a single string value.
			/// </summary>
			/// <param name="fieldName">The field name for which to return the value - can be an XPath-like query: data[*].Message.</param>
			/// <returns></returns>
			public string GetSingleField(string fieldName)
			{
				return _parsedJson.SelectToken(fieldName).ToString();
			}
		}
	}
}
