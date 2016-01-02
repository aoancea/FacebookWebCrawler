using System.Runtime.Serialization;

namespace Crawler.Github.Api.Entities
{
    public class Milestone
	{
		[DataMember(Name = "url")]
		public string Url { get; set; }

		[DataMember(Name = "html_url")]
		public string Html_Url { get; set; }

		[DataMember(Name = "labels_url")]
		public string Labels_Url { get; set; }

		[DataMember(Name = "id")]
		public int Id { get; set; }

		[DataMember(Name = "number")]
		public int Number { get; set; }

		[DataMember(Name = "title")]
		public int Title { get; set; }

		[DataMember(Name = "description")]
		public int Description { get; set; }

		[DataMember(Name = "creator")]
		public User Creator { get; set; }
	}
}