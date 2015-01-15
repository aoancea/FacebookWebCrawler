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
			Crawler crawler = new Crawler("913819931996488|2e3ef18f88e42c9068d8a6dba3b14021");

			Crawler.CrawlerQueryResult result = await crawler.ExecuteQuery("klausiohannis/feed");

			foreach (string field in result.GetField("message"))
			{
				textBox1.Text += field + Environment.NewLine + "- - - -" + Environment.NewLine + Environment.NewLine;
			}
			
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
	}
}
