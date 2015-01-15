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
			/// <summary>
			/// Gets the raw query result.
			/// </summary>
			public string RawResult
			{
				get;
				internal set;
			}

			/// <summary>
			/// Gets an enumerable with the values for a given field name.
			/// </summary>
			/// <param name="fieldName">The field name for which to return values.</param>
			/// <returns></returns>
			public IEnumerable<string> GetField(string fieldName)
			{
				JObject json = JObject.Parse(this.RawResult);

				return json.SelectTokens("data[*]." + fieldName).Select(x => x.ToString());
			}
		}
	}
}
