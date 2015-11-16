using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Crawler.Github.Api.Entities
{
	public class Comment
	{
		[DataMember(Name = "url")]
		public string Url { get; set; }

		[DataMember(Name = "html_url")]
		public string Html_Url { get; set; }

		[DataMember(Name = "issue_url")]
		public string Issue_Url { get; set; }

		[DataMember(Name = "id")]
		public int Id { get; set; }

		[DataMember(Name = "user")]
		public User User { get; set; }

		[DataMember(Name = "created_at")]
		public DateTime Created_At { get; set; }

		[DataMember(Name = "updated_at")]
		public DateTime? Updated_At { get; set; }

		[DataMember(Name = "body")]
		public string Body { get; set; }
	}
}