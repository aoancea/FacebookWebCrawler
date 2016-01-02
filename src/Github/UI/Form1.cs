using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Crawler.Github.Api;
using Crawler.Github.Api.Entities;

namespace Crawler.Github.UI
{
    public partial class Form1 : Form
    {
        private Queue<string> accessTokens;
        object resultsLocker = new object();

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
            accessTokens = new Queue<string>();
            foreach (string accessToken in tbxAccessToken.Lines)
            {
                if (!string.IsNullOrEmpty(accessToken) && !string.IsNullOrWhiteSpace(accessToken))
                {
                    accessTokens.Enqueue(accessToken);
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


            Parallel.For(pageFrom, pageTo, async (page, loopState) =>
            {
                var localDict = new Dictionary<string, string>(queryStringDict);
                localDict["page"] = page.ToString();
                List<Issue> issues = await githubApi.IssuesApi.GetAsync(tbxRepoOwner.Text, tbxRepoName.Text, localDict);

                if (issues.Count == 0)
                {
                    loopState.Break();
                }

                Parallel.ForEach(issues, async issue =>
                {
                    List<Comment> comments = null;
                    if (cbxFetchComments.Checked)
                    {
                        comments = await githubApi.CommentsApi.GetAsync(issue);
                    }

                    SaveIssue(issue, comments, issuesFolderPath);

                    progress.Report(new ProgressBundle { RequestsRemaining = githubContext.RequestsRemaining, UpdateProgressBar = false });
                });


                progress.Report(new ProgressBundle { RequestsRemaining = githubContext.RequestsRemaining, UpdateProgressBar = true });
                /*lock (resultsLocker)
				{
					if (progressBar.InvokeRequired)
					{
						progressBar.Invoke(new Action(() => progressBar.PerformStep()));
					}
					else
					{
						progressBar.PerformStep();
					}

					if (txtProgressCount.InvokeRequired)
					{
						txtProgressCount.Invoke(new Action(() => txtProgressCount.Text = progressBar.Value + " / " + progressBar.Maximum + " pages"));
					}
					else
					{
						txtProgressCount.Text = progressBar.Value + " / " + progressBar.Maximum + " pages";
					}

					if (tbxRequestsRemaining.InvokeRequired)
					{
						tbxRequestsRemaining.Invoke(new Action(() => tbxRequestsRemaining.Text = githubContext.RequestsRemaining + " requests remaining (" + accessTokens.Count + " other access token(s))"));
					}
					else
					{
						tbxRequestsRemaining.Text = githubContext.RequestsRemaining + " requests remaining (" + accessTokens.Count + " other access token(s))"; ;
					}
				}*/
            });
        }
        private async void btnStart_Click(object sender, EventArgs e)
        {
            txtProgressCount.Text = "0";
            progressBar.Value = progressBar.Minimum;

            GetAccessTokens();

            string issuesFolderPath = IssuesFolderPath();

            Uri uri = new Uri(string.Format("https://api.github.com/repos/{0}/{1}/issues?page=1&state={2}", tbxRepoOwner.Text, tbxRepoName.Text, GetStateString()));
            GithubContext githubContext = new GithubContext(accessTokens);

            int numPages = await githubContext.GetNumPagesAsync(uri);
            //int[] intervals = { 0, 1, 2, 3 };
            //int countPerWorker = numPages / intervals.Length;

            progressBar.Maximum = numPages;

            //await Task.WhenAll(intervals.Select(i => GetIssuesWorker(i * countPerWorker, (i + 1) * countPerWorker + (i + 1 == intervals.Length ? numPages % intervals.Length + 1 : 0), issuesFolderPath)));
            var progress = new Progress<ProgressBundle>();
            progress.ProgressChanged += Progress_ProgressChanged;

            await Task.Run(() => GetIssuesWorker(0, numPages, issuesFolderPath, githubContext, progress));
        }

        private void Progress_ProgressChanged(object sender, ProgressBundle e)
        {
            if (e.UpdateProgressBar)
            {
                progressBar.PerformStep();
                txtProgressCount.Text = progressBar.Value + " / " + progressBar.Maximum + " pages";
            }
            tbxRequestsRemaining.Text = e.RequestsRemaining + " requests remaining (" + accessTokens.Count + " other access token(s))";
        }

        private void SaveIssue(Issue issue, List<Comment> comments, string issuesFolderPath)
        {
            if (issue.Pull_Request != null && !cbxFetchPullRequests.Checked)
            {
                return;
            }

            string issueFolderPath = IssueFolderPath(issue, issuesFolderPath);
            StringBuilder sb = new StringBuilder();
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

            SaveIssueToFile(sb.ToString(), issueFolderPath);
            SaveIssueLabels(issue, issueFolderPath);
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
            string issueFolderName = issue.Number.ToString();
            if (issue.Closed_at != null)
            {
                issueFolderName += string.Format(" - {0}", (issue.Closed_at - issue.Created_at).Value.TotalHours);
            }
            string issueFolderPath = Path.Combine(issuesFolderPath, issueFolderName);

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

        private void btnBrowseFolder_Click(object sender, EventArgs e)
        {
            if (fldrBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                tbxFolderPath.Text = fldrBrowserDialog.SelectedPath;
            }
        }
    }
}