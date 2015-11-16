using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crawler.Core.Common.Extensions
{
	public static class DictionaryExtentions
	{
		public static string ToQueryString(this Dictionary<string, string> query)
		{
			if (query != null)
			{
				StringBuilder sb = new StringBuilder();

				Dictionary<string, string>.Enumerator enumerator = query.GetEnumerator();
				enumerator.MoveNext();

				sb.AppendFormat("?{0}={1}", enumerator.Current.Key, enumerator.Current.Value);

				while (enumerator.MoveNext())
				{
					sb.AppendFormat("&{0}={1}", enumerator.Current.Key, enumerator.Current.Value);
				}

				return sb.ToString();
			}

			return null;
		}
	}
}