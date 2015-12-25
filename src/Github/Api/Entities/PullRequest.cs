using System.Runtime.Serialization;


namespace Crawler.Github.Api.Entities
{
	public class PullRequest
	{
		[DataMember(Name = "url")]
		public string Url { get; set; }

		[DataMember(Name = "html_url")]
		public string Html_Url { get; set; }

		[DataMember(Name = "diff_url")]
		public string Diff_Url { get; set; }

		[DataMember(Name = "patch_url")]
		public string Patch_Url { get; set; }

	}
}