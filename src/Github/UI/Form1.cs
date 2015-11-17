using Crawler.Github.Api;
using Crawler.Github.Api.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
			string issuesFolderPath = IssuesFolderPath();

			int fetchedPage = 0;

			GithubContext githubContext = new GithubContext(tbxAccessToken.Text);

			GithubApi githubApi = new GithubApi(githubContext);

			List<Issue> issues = await githubApi.IssuesApi.GetAsync(tbxRepoOwner.Text, tbxRepoName.Text, new Dictionary<string, string>() { { "page", (++fetchedPage).ToString() } });

			while (issues.Count > 0)
			{
				foreach (Issue issue in issues.Where(issue => issue.Comments > 0))
				{
					List<Comment> comments = await githubApi.CommentsApi.GetAsync(issue);

					foreach (Comment comment in comments)
					{
						using (StreamWriter writer = new StreamWriter(Path.Combine(issuesFolderPath, comment.Id + ".txt")))
						{
							writer.WriteLine(comment.Body);
						}
					}
				}

				issues = await githubApi.IssuesApi.GetAsync(tbxRepoOwner.Text, tbxRepoName.Text, new Dictionary<string, string>() { { "page", (++fetchedPage).ToString() } });
			}
		}

		private string IssuesFolderPath()
		{
			string selectedIssuesPath;

			if (string.IsNullOrEmpty(tbxFolderPath.Text))
				selectedIssuesPath = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "Data");
			else
				selectedIssuesPath = tbxFolderPath.Text;

			string virtualFolderName = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");

			string issuesFolderPath = Path.Combine(selectedIssuesPath, virtualFolderName, "comments");

			if (!System.IO.Directory.Exists(issuesFolderPath))
				System.IO.Directory.CreateDirectory(issuesFolderPath);

			return issuesFolderPath;
		}
	}
}