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
			int postsFetched = 0;
			int commentsFetched = 0;

			Crawler crawler = new Crawler("913819931996488|2e3ef18f88e42c9068d8a6dba3b14021");

			Crawler.CrawlerQueryResult queryResult = await crawler.ExecuteQueryAsync(txtUrl.Text);

			List<JToken> posts = queryResult.GetFieldToken("data[*]").ToList();

			while (posts.Count > 0 && FetchPosts(postsFetched, commentsFetched))
			{
				
			}

		}

		private bool FetchPosts(int postsFetched, int commentsFetched)
		{
			if (rdoGetPosts.Checked)
				return postsFetched < numMaxNumberOfPostsToFetch.Value;

			if (rdoGetComments.Checked)
				return commentsFetched < numMaxNumberOfCommentsToFetch.Value;

			return false;
		}
	}
}