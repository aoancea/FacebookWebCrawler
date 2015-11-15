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

		[DataMember(Name = "number")]
		public int Number { get; set; }

		[DataMember(Name = "title")]
		public string Title { get; set; }

		[DataMember(Name = "user")]
		public User User { get; set; }

		[DataMember(Name = "labels")]
		public List<Label> Labels { get; set; }

		[DataMember(Name = "state")]
		public string State { get; set; }

		[DataMember(Name = "locked")]
		public bool Locked { get; set; }

		[DataMember(Name = "assignee")]
		public User Assignee { get; set; }

		[DataMember(Name = "milestone")]
		public Milestone Milestone { get; set; }

		[DataMember(Name = "comments")]
		public int Comments { get; set; }

		[DataMember(Name = "created_at")]
		public DateTime Created_at { get; set; }

		[DataMember(Name = "updated_at")]
		public DateTime? Updated_at { get; set; }

		[DataMember(Name = "closed_at")]
		public DateTime? Closed_at { get; set; }

		[DataMember(Name = "body")]
		public string Body { get; set; }
	}
}