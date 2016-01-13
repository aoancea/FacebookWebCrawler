using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Crawler.Github.Api.Entities
{
	class GitEvent
	{
		[DataMember(Name = "id")]
		public int Id { get; set; }

		[DataMember(Name = "url")]
		public string Url { get; set; }

		[DataMember(Name = "actor")]
		public User Actor { get; set; }

		[DataMember(Name = "event")]
		public string Event { get; set; }

		[DataMember(Name = "commit_id")]
		public string Commit_Id { get; set; }

		[DataMember(Name = "commit_url")]
		public string Commit_Url { get; set; }

		[DataMember(Name = "created_at")]
		public DateTime Created_At { get; set; }
	}
}
