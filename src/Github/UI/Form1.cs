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

			var queryStringDict = new Dictionary<string, string>();
			queryStringDict.Add("page", (++fetchedPage).ToString());
			string fetchTypeString;
			if (cbxFetchClosedIssues.Checked && cbxFetchOpenIssues.Checked)
			{
				fetchTypeString = "all";
			}
			else if (cbxFetchOpenIssues.Checked)
			{
				fetchTypeString = "open";
			}
			else
			{
				fetchTypeString = "closed";
			}
			queryStringDict.Add("state", fetchTypeString);
			List<Issue> issues = await githubApi.IssuesApi.GetAsync(tbxRepoOwner.Text, tbxRepoName.Text, new Dictionary<string, string>() { { "page", (++fetchedPage).ToString() } });

			while (issues.Count > 0)
			{
				foreach (Issue issue in issues.Where(issue => issue.Comments > 0))
				{
					List<Comment> comments = await githubApi.CommentsApi.GetAsync(issue);

					SaveIssue(issue, comments, issuesFolderPath);
				}

				issues = await githubApi.IssuesApi.GetAsync(tbxRepoOwner.Text, tbxRepoName.Text, new Dictionary<string, string>() { { "page", (++fetchedPage).ToString() } });
			}
		}

		private void SaveIssue(Issue issue, List<Comment> comments, string issuesFolderPath)
		{
			if (issue.PullRequest != null && !cbxFetchPullRequests.Checked)
			{
				return;
			}

			string issueFolderPath = IssueFolderPath(issue, issuesFolderPath);

			if (cbxConcatCommentsToIssueText.Checked)
			{
				StringBuilder sb = new StringBuilder();
				sb.AppendLine(issue.Body);

				foreach (Comment comment in comments)
				{
					sb.AppendLine(comment.Body);
				}

				SaveIssueToFile(sb.ToString(), issueFolderPath);

				SaveIssueLabels(issue, issueFolderPath);
			}
			else
			{
				SaveIssueToFile(issue.Body, issueFolderPath);

				SaveIssueLabels(issue, issueFolderPath);

				foreach (Comment comment in comments)
				{
					SaveCommentToFile(comment.Body, issueFolderPath, comment.Id.ToString());
				}
			}
		}

		private void SaveIssueLabels(Issue issue, string issueFolderPath)
		{
			StringBuilder sb = new StringBuilder();

			foreach (Crawler.Github.Api.Entities.Label label in issue.Labels)
			{
				sb.AppendLine(label.Name);
			}

			using (StreamWriter writer = new StreamWriter(Path.Combine(issueFolderPath, "labels.txt")))
			{
				writer.WriteLine(sb.ToString());
			}
		}

		private void SaveIssueToFile(string issueText, string issueFolderPath)
		{
			using (StreamWriter writer = new StreamWriter(Path.Combine(issueFolderPath, "issue.txt")))
			{
				writer.WriteLine(issueText);
			}
		}

		private void SaveCommentToFile(string commentText, string issueFolderPath, string commentId)
		{
			using (StreamWriter writer = new StreamWriter(Path.Combine(issueFolderPath, string.Format("comment{0}.txt", commentId))))
			{
				writer.WriteLine(commentText);
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

			string issuesFolderPath = Path.Combine(selectedIssuesPath, virtualFolderName, "issues");

			if (!System.IO.Directory.Exists(issuesFolderPath))
				System.IO.Directory.CreateDirectory(issuesFolderPath);

			return issuesFolderPath;
		}

		private string IssueFolderPath(Issue issue, string issuesFolderPath)
		{
			string issueFolderPath = Path.Combine(issuesFolderPath, issue.Id.ToString());

			if (!System.IO.Directory.Exists(issueFolderPath))
				System.IO.Directory.CreateDirectory(issueFolderPath);

			return issueFolderPath;
		}


		private void cbxFetchOpenIssues_CheckedChanged(object sender, EventArgs e)
		{
			if (!cbxFetchClosedIssues.Checked && !cbxFetchOpenIssues.Checked)
			{
				cbxFetchOpenIssues.Checked = true;
			}
		}

		private void cbxFetchClosedIssues_CheckedChanged(object sender, EventArgs e)
		{
			if (!cbxFetchClosedIssues.Checked && !cbxFetchOpenIssues.Checked)
			{
				cbxFetchClosedIssues.Checked = true;
			}
		}
	}
}