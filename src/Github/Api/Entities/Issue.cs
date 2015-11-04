using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Crawler.Github.Api.Entities
{
	public class Issue
	{
		[DataMember(Name = "url")]
		public string Url { get; set; }

		[DataMember(Name = "id")]
		public int Id { get; set; }

		[DataMember(Name = "number")]
		public int Number { get; set; }
	}
}