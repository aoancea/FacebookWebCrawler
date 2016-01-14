using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Crawler.Github.Api;
using Crawler.Github.Api.Entities;
using Crawler.Core.Common.Queue;

namespace Crawler.Github.UI
{
    public partial class Form1 : Form
    {
		private object locker = new object();
        private List<string> accessTokens;

        public Form1()
        {
            InitializeComponent();
        }

        private string GetStateString()
        {
            if (cbxFetchClosedIssues.Checked && cbxFetchOpenIssues.Checked)
            {
                return "all";
            }
            else if (cbxFetchOpenIssues.Checked)
            {
                return "open";
            }

            return "closed";
        }

        private void GetAccessTokens()
        {
			accessTokens = new List<string>();
            foreach (string accessToken in tbxAccessToken.Lines)
            {
                if (!string.IsNullOrEmpty(accessToken) && !string.IsNullOrWhiteSpace(accessToken))
                {
					accessTokens.Add(accessToken);
                }
            }
		}

		private void GetIssuesWorker(int pageFrom, int pageTo, string issuesFolderPath, GithubContext githubContext, IProgress<ProgressBundle> progress)
        {
            GithubApi githubApi = new GithubApi(githubContext);

            var queryStringDict = new Dictionary<string, string>();
            queryStringDict.Add("page", pageFrom.ToString());
            string fetchTypeString = GetStateString();

            queryStringDict.Add("state", fetchTypeString);

			ParallelOptions optionsPages = new ParallelOptions();
			ParallelOptions optionsIssues = new ParallelOptions();

			optionsPages.MaxDegreeOfParallelism = 2;
			optionsIssues.MaxDegreeOfParallelism = 2;
            Parallel.For(pageFrom, pageTo, optionsPages, (page, loopState) =>
            {
                var localDict = new Dictionary<string, string>(queryStringDict);
                localDict["page"] = page.ToString();

				List<Issue> issues = githubApi.IssuesApi.Get(tbxRepoOwner.Text, tbxRepoName.Text, localDict);

                if (issues.Count == 0)
                {
                    loopState.Break();
                }

                Parallel.ForEach(issues, optionsIssues, issue =>
                {
                    List<Comment> comments = null;
					List<GitCommit> commits = null;
                    if (cbxFetchComments.Checked)
                    {
						comments = githubApi.CommentsApi.Get(issue);
                    }

					if (cbxFetchCommits.Checked)
					{
						commits = githubApi.CommitsApi.Get(issue);
					}

                    SaveIssue(issue, comments, commits, issuesFolderPath, page);

					progress.Report(new ProgressBundle { RequestsRemaining = githubContext.RequestsRemaining, UpdatePagesProgressBar = false, CountTokens = githubContext.CountTokens });
				});

                progress.Report(new ProgressBundle { RequestsRemaining = githubContext.RequestsRemaining, UpdatePagesProgressBar = true, CountTokens = githubContext.CountTokens });
            });
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            txtProgressCount.Text = "0";
            progressBarPages.Value = progressBarPages.Minimum;

            GetAccessTokens();

            string issuesFolderPath = IssuesFolderPath();

			Uri uri = GetRequestUri();
            GithubContext githubContext = new GithubContext(accessTokens);

            int numPages = await githubContext.GetNumPagesAsync(uri);
            progressBarPages.Maximum = numPages;
			txtProgressCount.Text = progressBarPages.Value + " / " + progressBarPages.Maximum + " pages";

			var progress = new Progress<ProgressBundle>();
			progress.ProgressChanged += Progress_ProgressChanged;

            await Task.Run(() => GetIssuesWorker(0, numPages, issuesFolderPath, githubContext, progress));
        }

		private Uri GetRequestUri()
		{
			string str = string.Format(
				"https://api.github.com/repos/{0}/{1}/issues?page=1&state={2}", 
				tbxRepoOwner.Text, 
				tbxRepoName.Text, 
				GetStateString());

			if (cbxLabelOneOf.Checked)
			{
				str += "&labels=";
				foreach (string label in tbxLabelOneOf.Lines)
				{
					str += label + ",";
				}

				str.Remove(str.Length - 1);
			}

			return new Uri(str);
		}

		private void Progress_ProgressChanged(object sender, ProgressBundle e)
        {
            if (e.UpdatePagesProgressBar)
            {
				progressBarPages.Value += 1;
				txtProgressCount.Text = progressBarPages.Value + " / " + progressBarPages.Maximum + " pages";
            }

            tbxRequestsRemaining.Text = e.RequestsRemaining + " requests remaining (" + e.CountTokens + " access token(s))";
        }

        private void SaveIssue(Issue issue, List<Comment> comments, List<GitCommit> commits, string issuesFolderPath, int page)
        {
            if (issue.Pull_Request != null && !cbxFetchPullRequests.Checked)
            {
                return;
            }

            string issueFolderPath = IssueFolderPath(issue, issuesFolderPath);
            StringBuilder sb = new StringBuilder();
			for (int i = 0; i < int.Parse(tbxRepeatTitle.Text); ++i)
			{
				sb.AppendLine(issue.Title);
			}
			sb.AppendLine(issue.Body);

            if (cbxConcatCommentsToIssueText.Checked)
            {
                if (cbxFetchComments.Checked)
                {
                    foreach (Comment comment in comments)
                    {
                        sb.AppendLine(comment.Body);
                    }
                }
            }
            else
            {
                if (cbxFetchComments.Checked)
                {
                    foreach (Comment comment in comments)
                    {
                        SaveCommentToFile(comment.Body, issueFolderPath, comment.Id.ToString());
                    }
                }
            }
			
			if (cbxFetchCommits.Checked)
			{
				SaveIssueCommits(commits, issueFolderPath);
			}

            SaveIssueToFile(sb.ToString(), issueFolderPath);
            SaveIssueLabels(issue, issueFolderPath);
        }

        private void SaveIssueLabels(Issue issue, string issueFolderPath)
        {
            foreach (Crawler.Github.Api.Entities.Label label in issue.Labels)
            {
				string friendlyLabelName = label.Name.Replace(':', '-');
				using (StreamWriter writer = new StreamWriter(Path.Combine(issueFolderPath, "labels", friendlyLabelName + ".txt")))
				{
					writer.WriteLine(label.Name);
				}
			}
        }

		private void SaveIssueCommits(List<GitCommit> commits, string issueFolderPath)
		{
			int num = 1;
			foreach (GitCommit commit in commits)
			{
				string fileName = Path.Combine(issueFolderPath, "commits", commit?.Author.Login + " - " + commit?.Committer.Login + " - " + (num++) + ".txt");
				using (StreamWriter writer = new StreamWriter(fileName))
				{
					writer.WriteLine(commit.Commit.Message);
				}
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
            using (StreamWriter writer = new StreamWriter(Path.Combine(
																issueFolderPath, 
																"comments",
																string.Format("comment {0}.txt", commentId))))
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
            string issueFolderName = issue.User.Login + " - " + issue.Number.ToString();
            if (issue.Closed_at != null)
            {
                issueFolderName += string.Format(" - {0}", (issue.Closed_at - issue.Created_at).Value.TotalHours);
            }
            string issueFolderPath = Path.Combine(issuesFolderPath, issueFolderName);

			if (!System.IO.Directory.Exists(issueFolderPath))
			{
				System.IO.Directory.CreateDirectory(issueFolderPath);
				System.IO.Directory.CreateDirectory(Path.Combine(issueFolderPath, "labels"));
				System.IO.Directory.CreateDirectory(Path.Combine(issueFolderPath, "commits"));
				System.IO.Directory.CreateDirectory(Path.Combine(issueFolderPath, "comments"));
			}

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

        private void btnBrowseFolder_Click(object sender, EventArgs e)
        {
            if (fldrBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                tbxFolderPath.Text = fldrBrowserDialog.SelectedPath;
            }
        }
    }
}