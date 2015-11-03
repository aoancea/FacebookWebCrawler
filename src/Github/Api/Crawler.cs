using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crawler.Github.Api
{
	public class Crawler : Core.Common.Crawler
	{
		public Crawler()
		{

		}

		protected override bool Authenticate()
		{
			return base.Authenticate();
		}
	}
}