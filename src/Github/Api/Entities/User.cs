using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Crawler.Github.Api.Entities
{
	public class User
	{
		[DataMember(Name = "login")]
		public string Login { get; set; }

		[DataMember(Name = "id")]
		public int Id { get; set; }

		[DataMember(Name = "avatar_url")]
		public string Avatar_Url { get; set; }

		[DataMember(Name = "gravatar_id")]
		public string Gravatar_Id { get; set; }

		[DataMember(Name = "url")]
		public string Url { get; set; }

		[DataMember(Name = "html_url")]
		public string Html_Url { get; set; }

		[DataMember(Name = "followers_url")]
		public string Followers_Url { get; set; }

		[DataMember(Name = "following_url")]
		public string Following_Url { get; set; }

		[DataMember(Name = "gists_url")]
		public string Gists_Url { get; set; }
	}
}