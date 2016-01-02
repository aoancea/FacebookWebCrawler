using System.Runtime.Serialization;

namespace Crawler.Github.Api.Entities
{
    public class Label
	{
		[DataMember(Name = "url")]
		public string Url { get; set; }

		[DataMember(Name = "name")]
		public string Name { get; set; }

		[DataMember(Name = "color")]
		public string Color { get; set; }
	}
}