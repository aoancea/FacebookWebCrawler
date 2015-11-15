using Crawler.Github.Api;
using Crawler.Github.Api.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crawler.Github.UI
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private async void btnStart_Click(object sender, EventArgs e)
		{
			CrawlerContext crawlerContext = new CrawlerContext();

			IssuesApi issuesApi = new IssuesApi(crawlerContext);
			CommentsApi commentsApi = new CommentsApi(crawlerContext);

			List<Issue> issues = await issuesApi.GetAsync(tbxRepoOwner.Text, tbxRepoName.Text);

			foreach (Issue issue in issues)
			{
				List<Comment> comments = await commentsApi.GetAsync(issue);
			}
		}
	}
}