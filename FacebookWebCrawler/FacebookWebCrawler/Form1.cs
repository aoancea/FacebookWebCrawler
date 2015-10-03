using FBCrawlLib;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FacebookWebCrawler
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private async void button1_Click(object sender, EventArgs e)
		{
			progressBar1.MarqueeAnimationSpeed = 60;
			Crawler crawler = new Crawler("913819931996488|2e3ef18f88e42c9068d8a6dba3b14021");

			Crawler.CrawlerQueryResult queryResult = await crawler.ExecuteQueryAsync(txtUrl.Text);

			List<JToken> posts = queryResult.GetFieldToken("data[*]").ToList();

			DateTime earliestDate = new DateTime(2014, 7, 1);
			bool dateOk = true;

			using (StreamWriter writer = new StreamWriter(textBox2.Text))
			{
				while (posts.Count > 0 && dateOk)
				{
					foreach (JToken token in posts)
					{
						if (token["message"] != null)
						{
							DateTime date = DateTime.Parse(token["created_time"].ToString());
							if (date < earliestDate)
							{
								dateOk = false;
								break;
							}
							writer.WriteLine(token["message"].ToString() + Environment.NewLine + "---" + Environment.NewLine);
						}
					}

					queryResult = await crawler.ExecuteLinkAsync(queryResult.GetSingleField("paging.next"));
					posts = queryResult.GetFieldToken("data[*]").ToList();
				}
			}

			progressBar1.MarqueeAnimationSpeed = 0;
			progressBar1.Value = 0;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				textBox2.Text = saveFileDialog1.FileName;
			}
		}

		private async void btnProcessComments_Click(object sender, EventArgs e)
		{
			progressBarComments.MarqueeAnimationSpeed = 60;

			Crawler crawler = new Crawler("913819931996488|2e3ef18f88e42c9068d8a6dba3b14021");

			Crawler.CrawlerQueryResult queryResult = await crawler.ExecuteQueryAsync(txtUrl.Text);

			List<JToken> posts = queryResult.GetFieldToken("data[*]").ToList();

			DateTime earliestDate = new DateTime(2014, 7, 1);
			bool dateOk = true;

			using (StreamWriter writer = new StreamWriter(textBox2.Text))
			{
				while (posts.Count > 0 && dateOk)
				{
					foreach (JToken post in posts)
					{
						if (DateTime.Parse(post["created_time"].ToString()) < earliestDate)
						{
							dateOk = false;
							break;
						}

						JToken commentsTokenObject = post.SelectToken("comments");
						if (commentsTokenObject == null)
							continue;

						Crawler.CrawlerQueryResult commentsPageObject = new Crawler.CrawlerQueryResult();
						commentsPageObject.RawResult = commentsTokenObject.ToString();

						List<JToken> comments = commentsPageObject.GetFieldToken("data[*]").ToList();

						while (comments.Count > 0)
						{
							foreach (JToken comment in comments)
							{
								if (comment["message"] != null)
								{
									writer.WriteLine(comment["message"].ToString() + Environment.NewLine + "---" + Environment.NewLine);
								}
							}

							string nextPageUri = commentsPageObject.GetSingleField("paging.next");

							if (string.IsNullOrEmpty(nextPageUri))
								break;

							commentsPageObject = await crawler.ExecuteLinkAsync(nextPageUri);
							comments = commentsPageObject.GetFieldToken("data[*]").ToList();
						}
					}

					queryResult = await crawler.ExecuteLinkAsync(queryResult.GetSingleField("paging.next"));
					posts = queryResult.GetFieldToken("data[*]").ToList();
				}
			}

			progressBarComments.MarqueeAnimationSpeed = 0;
			progressBarComments.Value = 0;
		}

		private void RadioButton_Click(object sender, EventArgs e)
		{
			FacebookWebCrawler.Controls.RadioButton rb = (sender as FacebookWebCrawler.Controls.RadioButton);

			foreach (var c in this.groupBox4.Controls)
			{
				if (c is FacebookWebCrawler.Controls.RadioButton && (c as FacebookWebCrawler.Controls.RadioButton).GroupName == rb.GroupName)
				{
					(c as FacebookWebCrawler.Controls.RadioButton).Checked = false;
				}
			}

			foreach (var c in this.groupBox5.Controls)
			{
				if (c is FacebookWebCrawler.Controls.RadioButton && (c as FacebookWebCrawler.Controls.RadioButton).GroupName == rb.GroupName)
				{
					(c as FacebookWebCrawler.Controls.RadioButton).Checked = false;
				}
			}

			rb.Checked = true;
		}

		private void btnBrowseFolder_Click(object sender, EventArgs e)
		{
			if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				textboxFolderPath.Text = folderBrowserDialog1.SelectedPath;
			}
		}

		private async void btnProcess_Click(object sender, EventArgs e)
		{
			Dictionary<string, int> authorsIndexes = new Dictionary<string, int>();

			string virtualFolderName = DateTime.Now.ToString("yyyy-MM-dd-hh-mm-ss");

			string postsFolderPath = Path.Combine(textboxFolderPath.Text, txtUrl.Text, "posts", virtualFolderName);
			string commentsFolderPath = Path.Combine(textboxFolderPath.Text, txtUrl.Text, "comments", virtualFolderName);

			if (!System.IO.Directory.Exists(postsFolderPath))
				System.IO.Directory.CreateDirectory(postsFolderPath);

			if (!System.IO.Directory.Exists(commentsFolderPath))
				System.IO.Directory.CreateDirectory(commentsFolderPath);

			int postsFetched = 0;
			int commentsFetched = 0;

			Crawler crawler = new Crawler("913819931996488|2e3ef18f88e42c9068d8a6dba3b14021");

			Crawler.CrawlerQueryResult queryResult = await crawler.ExecuteQueryAsync(txtUrl.Text);

			List<JToken> posts = queryResult.GetFieldToken("data[*]").ToList();

			while (posts.Count > 0 && FetchPosts(postsFetched, commentsFetched))
			{
				bool continueFetchingPosts = true;

				foreach (JToken post in posts)
				{
					if (rdoGetPosts.Checked)
					{
						// save post

						using (StreamWriter writer = new StreamWriter(Path.Combine(postsFolderPath, postsFetched.ToString() + ".txt")))
						{
							writer.WriteLine(post["message"]);
						}

						if (!FetchPosts(++postsFetched, commentsFetched))
						{
							continueFetchingPosts = false;
							break;
						}
					}

					if (rdoGetComments.Checked)
					{
						int commentsPerPostFetched = 0;

						JToken commentsTokenObject = post.SelectToken("comments");

						if (commentsTokenObject == null)
							continue;

						Crawler.CrawlerQueryResult commentsPageObject = new Crawler.CrawlerQueryResult();
						commentsPageObject.RawResult = commentsTokenObject.ToString();

						List<JToken> comments = commentsPageObject.GetFieldToken("data[*]").ToList();

						while (comments.Count > 0 && FetchComments(commentsFetched, commentsPerPostFetched))
						{
							bool continueFetchingComments = true;

							foreach (JToken comment in comments)
							{
								// save comment

								using (StreamWriter writer = new StreamWriter(BuildCommentPath(commentsFolderPath, commentsFetched, comment, authorsIndexes)))
								{
									writer.WriteLine(comment["message"]);
								}

								if (!FetchComments(++commentsFetched, ++commentsPerPostFetched))
								{
									continueFetchingComments = false;
									break;
								}
							}

							if (continueFetchingComments)
							{
								string nextCommentPageUri = commentsPageObject.GetSingleField("paging.next");

								if (string.IsNullOrEmpty(nextCommentPageUri))
									break;

								commentsPageObject = await crawler.ExecuteLinkAsync(nextCommentPageUri);
								comments = commentsPageObject.GetFieldToken("data[*]").ToList();
							}
							else
								break;
						}
					}
				}

				if (continueFetchingPosts)
				{
					string nextPostPageUri = queryResult.GetSingleField("paging.next");

					if (string.IsNullOrEmpty(nextPostPageUri))
						break;

					queryResult = await crawler.ExecuteLinkAsync(nextPostPageUri);
					posts = queryResult.GetFieldToken("data[*]").ToList();
				}
				else
					break;
			}


			if (cbxGroupByAuthor.Checked)
			{
				foreach (var author in authorsIndexes)
				{
					string oldPath = Path.Combine(commentsFolderPath, author.Key);

					string[] filesInPath = System.IO.Directory.GetFiles(oldPath);

					string newPath = Path.Combine(commentsFolderPath, filesInPath.Length + " - " + author.Key);

					System.IO.Directory.Move(oldPath, newPath);
				}
			}
		}

		private bool FetchPosts(int postsFetched, int commentsFetched)
		{
			if (rdoGetPosts.Checked)
				return postsFetched < numMaxNumberOfPostsToFetch.Value;

			if (rdoGetComments.Checked)
				return commentsFetched < numMaxNumberOfCommentsToFetch.Value;

			return true;
		}

		private bool FetchComments(int commentsFetched, int commentsPerPostFetched)
		{
			return commentsFetched < numMaxNumberOfCommentsToFetch.Value && commentsPerPostFetched < numMaxNumberOfCommentsPerPostToFetch.Value;
		}

		private string BuildCommentPath(string commentsFolderPath, int commentIndex, JToken comment, Dictionary<string, int> authorsIndexes)
		{
			if (cbxGroupByAuthor.Checked)
			{
				string authorName = comment.SelectToken("from.name").ToString();

				commentsFolderPath = Path.Combine(commentsFolderPath, authorName);

				System.IO.Directory.CreateDirectory(commentsFolderPath);

				if (!authorsIndexes.ContainsKey(authorName))
					authorsIndexes.Add(authorName, 0);
				else
					authorsIndexes[authorName] = authorsIndexes[authorName] + 1;

				return Path.Combine(commentsFolderPath, authorsIndexes[authorName].ToString() + ".txt");
			}

			return Path.Combine(commentsFolderPath, commentIndex.ToString() + ".txt");
		}
	}
}