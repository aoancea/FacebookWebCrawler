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

		[DataMember(Name = "labels_url")]
		public string Labels_Url { get; set; }

		[DataMember(Name = "comments_url")]
		public string Comments_Url { get; set; }

		[DataMember(Name = "events_url")]
		public string Events_Url { get; set; }

		[DataMember(Name = "html_url")]
		public string Html_Url { get; set; }

		[DataMember(Name = "id")]
		public int Id { get; set; }

		[DataMember(Name = "title")]
		public string Title { get; set; }

		[DataMember(Name = "number")]
		public int Number { get; set; }
	}
}