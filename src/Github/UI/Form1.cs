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
			string commentsFolderPath = CommentsFolderPath();

			int fetchedPage = 0;

			GithubContext githubContext = new GithubContext();

			GithubApi githubApi = new GithubApi(githubContext);

			List<Issue> issues = await githubApi.IssuesApi.GetAsync(tbxRepoOwner.Text, tbxRepoName.Text, new Dictionary<string, string>() { { "page", (++fetchedPage).ToString() } });

			while (issues.Count > 0)
			{
				foreach (Issue issue in issues.Where(issue => issue.Comments > 0))
				{
					List<Comment> comments = await githubApi.CommentsApi.GetAsync(issue);

					foreach (Comment comment in comments)
					{
						using (StreamWriter writer = new StreamWriter(Path.Combine(commentsFolderPath, comment.Id + ".txt")))
						{
							writer.WriteLine(comment.Body);
						}
					}
				}

				issues = await githubApi.IssuesApi.GetAsync(tbxRepoOwner.Text, tbxRepoName.Text, new Dictionary<string, string>() { { "page", (++fetchedPage).ToString() } });
			}
		}

		private string CommentsFolderPath()
		{
			string selectedCommentsPath;

			if (string.IsNullOrEmpty(tbxFolderPath.Text))
				selectedCommentsPath = System.AppDomain.CurrentDomain.BaseDirectory;
			else
				selectedCommentsPath = tbxFolderPath.Text;

			string virtualFolderName = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");

			string commentsFolderPath = Path.Combine(selectedCommentsPath, virtualFolderName, "comments");

			if (!System.IO.Directory.Exists(commentsFolderPath))
				System.IO.Directory.CreateDirectory(commentsFolderPath);

			return commentsFolderPath;
		}
	}
}