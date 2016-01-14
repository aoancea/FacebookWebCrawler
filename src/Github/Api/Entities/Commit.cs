using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crawler.Github.Api.Entities
{
	public class Commit
	{
		public string Message { get; set; }
	}

	public class GitCommit
	{
		public string Sha { get; set; }
		public Commit Commit { get; set; }
		public User Author { get; set; }
		public User Committer { get; set; }
	}
}
