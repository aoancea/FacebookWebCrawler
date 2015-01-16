using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using FBCrawlLib;
using System.IO;
using Newtonsoft.Json.Linq;

namespace FacebookWebCrawler
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		HtmlDocument htmlDocument = null;

		private async void button1_Click(object sender, EventArgs e)
		{
			progressBar1.MarqueeAnimationSpeed = 60;
			Crawler crawler = new Crawler("913819931996488|2e3ef18f88e42c9068d8a6dba3b14021");

			Crawler.CrawlerQueryResult queryResult = await crawler.ExecuteQuery(txtUrl.Text);

			
			List<JToken> results = queryResult.GetFieldToken("data[*]").ToList();

			DateTime earliestDate = new DateTime(2014, 7, 1);
			bool dateOk = true;
			using (StreamWriter writer = new StreamWriter(textBox2.Text))
			{
				while (results.Count > 0 && dateOk)
				{
					foreach (JToken token in results)
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

					queryResult = await crawler.ExecuteLink(queryResult.GetSingleField("paging.next"));
					results = queryResult.GetFieldToken("data[*]").ToList();
				}
			}

			progressBar1.MarqueeAnimationSpeed = 0;
			progressBar1.Value = 0;

			//WebBrowser webBrowser = new WebBrowser();
			//webBrowser.Navigate(txtUrl.Text);

			//webBrowser.DocumentCompleted += (documentSender, documentEventArgs) =>
			//{
			//	htmlDocument = webBrowser.Document;

			//	HtmlElementCollection allDivCollection = htmlDocument.GetElementsByTagName("div");

			//	List<HtmlElement> commentContainerCollection = new List<HtmlElement>();

			//	foreach (HtmlElement htmlElement in allDivCollection)
			//	{
			//		if (htmlElement.GetAttribute("className").Contains("_4-u2 mbm _5jmm _5pat _5v3q"))
			//		{
			//			commentContainerCollection.Add(htmlElement);
			//		}
			//	}

			//	var x = 1;


			//};
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				textBox2.Text = saveFileDialog1.FileName;
			}
		}
	}
}
