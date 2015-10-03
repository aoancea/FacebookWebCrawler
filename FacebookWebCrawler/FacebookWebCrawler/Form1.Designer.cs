namespace FacebookWebCrawler
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtUrl = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnProcess = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.btnBrowseFolder = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.textboxFolderPath = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.label9 = new System.Windows.Forms.Label();
			this.numMinimumCommenLength = new System.Windows.Forms.NumericUpDown();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.cbxGroupByAuthor = new System.Windows.Forms.CheckBox();
			this.rdoGetComments = new FacebookWebCrawler.Controls.RadioButton();
			this.numMaxNumberOfCommentsPerPostToFetch = new System.Windows.Forms.NumericUpDown();
			this.label8 = new System.Windows.Forms.Label();
			this.numMaxNumberOfCommentsToFetch = new System.Windows.Forms.NumericUpDown();
			this.label7 = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.numMaxNumberOfPostsToFetch = new System.Windows.Forms.NumericUpDown();
			this.rdoGetPosts = new FacebookWebCrawler.Controls.RadioButton();
			this.label6 = new System.Windows.Forms.Label();
			this.btnProcessComments = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.progressBarComments = new System.Windows.Forms.ProgressBar();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.button2 = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.progressBar = new System.Windows.Forms.ProgressBar();
			this.groupBox1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numMinimumCommenLength)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numMaxNumberOfCommentsPerPostToFetch)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numMaxNumberOfCommentsToFetch)).BeginInit();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numMaxNumberOfPostsToFetch)).BeginInit();
			this.SuspendLayout();
			// 
			// txtUrl
			// 
			this.txtUrl.Location = new System.Drawing.Point(56, 19);
			this.txtUrl.Name = "txtUrl";
			this.txtUrl.Size = new System.Drawing.Size(555, 20);
			this.txtUrl.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.progressBar);
			this.groupBox1.Controls.Add(this.btnProcess);
			this.groupBox1.Controls.Add(this.groupBox3);
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Controls.Add(this.btnProcessComments);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.progressBarComments);
			this.groupBox1.Controls.Add(this.progressBar1);
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.textBox2);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtUrl);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(5, 5);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(617, 676);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Action";
			// 
			// btnProcess
			// 
			this.btnProcess.Location = new System.Drawing.Point(6, 270);
			this.btnProcess.Name = "btnProcess";
			this.btnProcess.Size = new System.Drawing.Size(605, 23);
			this.btnProcess.TabIndex = 14;
			this.btnProcess.Text = "Process";
			this.btnProcess.UseVisualStyleBackColor = true;
			this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.btnBrowseFolder);
			this.groupBox3.Controls.Add(this.label5);
			this.groupBox3.Controls.Add(this.textboxFolderPath);
			this.groupBox3.Location = new System.Drawing.Point(6, 207);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(605, 57);
			this.groupBox3.TabIndex = 13;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Save settings";
			// 
			// btnBrowseFolder
			// 
			this.btnBrowseFolder.Location = new System.Drawing.Point(493, 19);
			this.btnBrowseFolder.Name = "btnBrowseFolder";
			this.btnBrowseFolder.Size = new System.Drawing.Size(106, 23);
			this.btnBrowseFolder.TabIndex = 2;
			this.btnBrowseFolder.Text = "Browse";
			this.btnBrowseFolder.UseVisualStyleBackColor = true;
			this.btnBrowseFolder.Click += new System.EventHandler(this.btnBrowseFolder_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 25);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(42, 13);
			this.label5.TabIndex = 1;
			this.label5.Text = "Folder: ";
			// 
			// textboxFolderPath
			// 
			this.textboxFolderPath.Location = new System.Drawing.Point(54, 22);
			this.textboxFolderPath.Name = "textboxFolderPath";
			this.textboxFolderPath.Size = new System.Drawing.Size(433, 20);
			this.textboxFolderPath.TabIndex = 0;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.groupBox5);
			this.groupBox2.Controls.Add(this.groupBox4);
			this.groupBox2.Location = new System.Drawing.Point(6, 45);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(605, 160);
			this.groupBox2.TabIndex = 12;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Retrieval settings";
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.label9);
			this.groupBox5.Controls.Add(this.numMinimumCommenLength);
			this.groupBox5.Controls.Add(this.checkBox2);
			this.groupBox5.Controls.Add(this.cbxGroupByAuthor);
			this.groupBox5.Controls.Add(this.rdoGetComments);
			this.groupBox5.Controls.Add(this.numMaxNumberOfCommentsPerPostToFetch);
			this.groupBox5.Controls.Add(this.label8);
			this.groupBox5.Controls.Add(this.numMaxNumberOfCommentsToFetch);
			this.groupBox5.Controls.Add(this.label7);
			this.groupBox5.Location = new System.Drawing.Point(9, 78);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(590, 77);
			this.groupBox5.TabIndex = 2;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Comments";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(256, 55);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(132, 13);
			this.label9.TabIndex = 9;
			this.label9.Text = "Minimum comment length: ";
			// 
			// numMinimumCommenLength
			// 
			this.numMinimumCommenLength.Location = new System.Drawing.Point(394, 54);
			this.numMinimumCommenLength.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			this.numMinimumCommenLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numMinimumCommenLength.Name = "numMinimumCommenLength";
			this.numMinimumCommenLength.Size = new System.Drawing.Size(120, 20);
			this.numMinimumCommenLength.TabIndex = 8;
			this.numMinimumCommenLength.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// checkBox2
			// 
			this.checkBox2.AutoSize = true;
			this.checkBox2.Location = new System.Drawing.Point(116, 54);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(90, 17);
			this.checkBox2.TabIndex = 7;
			this.checkBox2.Text = "Get metadata";
			this.checkBox2.UseVisualStyleBackColor = true;
			// 
			// cbxGroupByAuthor
			// 
			this.cbxGroupByAuthor.AutoSize = true;
			this.cbxGroupByAuthor.Location = new System.Drawing.Point(6, 54);
			this.cbxGroupByAuthor.Name = "cbxGroupByAuthor";
			this.cbxGroupByAuthor.Size = new System.Drawing.Size(103, 17);
			this.cbxGroupByAuthor.TabIndex = 6;
			this.cbxGroupByAuthor.Text = "Group by Author";
			this.cbxGroupByAuthor.UseVisualStyleBackColor = true;
			// 
			// rdoGetComments
			// 
			this.rdoGetComments.AutoSize = true;
			this.rdoGetComments.GroupName = "group1";
			this.rdoGetComments.Location = new System.Drawing.Point(6, 0);
			this.rdoGetComments.Name = "rdoGetComments";
			this.rdoGetComments.Size = new System.Drawing.Size(93, 17);
			this.rdoGetComments.TabIndex = 1;
			this.rdoGetComments.TabStop = true;
			this.rdoGetComments.Text = "Get comments";
			this.rdoGetComments.UseVisualStyleBackColor = true;
			this.rdoGetComments.Click += new System.EventHandler(this.RadioButton_Click);
			// 
			// numMaxNumberOfCommentsPerPostToFetch
			// 
			this.numMaxNumberOfCommentsPerPostToFetch.Location = new System.Drawing.Point(394, 20);
			this.numMaxNumberOfCommentsPerPostToFetch.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			this.numMaxNumberOfCommentsPerPostToFetch.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numMaxNumberOfCommentsPerPostToFetch.Name = "numMaxNumberOfCommentsPerPostToFetch";
			this.numMaxNumberOfCommentsPerPostToFetch.Size = new System.Drawing.Size(120, 20);
			this.numMaxNumberOfCommentsPerPostToFetch.TabIndex = 5;
			this.numMaxNumberOfCommentsPerPostToFetch.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(189, 22);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(199, 13);
			this.label8.TabIndex = 4;
			this.label8.Text = "Maximum number of comments per post: ";
			// 
			// numMaxNumberOfCommentsToFetch
			// 
			this.numMaxNumberOfCommentsToFetch.Location = new System.Drawing.Point(62, 20);
			this.numMaxNumberOfCommentsToFetch.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			this.numMaxNumberOfCommentsToFetch.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numMaxNumberOfCommentsToFetch.Name = "numMaxNumberOfCommentsToFetch";
			this.numMaxNumberOfCommentsToFetch.Size = new System.Drawing.Size(120, 20);
			this.numMaxNumberOfCommentsToFetch.TabIndex = 3;
			this.numMaxNumberOfCommentsToFetch.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(6, 22);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(50, 13);
			this.label7.TabIndex = 0;
			this.label7.Text = "Number: ";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.numMaxNumberOfPostsToFetch);
			this.groupBox4.Controls.Add(this.rdoGetPosts);
			this.groupBox4.Controls.Add(this.label6);
			this.groupBox4.Location = new System.Drawing.Point(9, 19);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(590, 53);
			this.groupBox4.TabIndex = 1;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Posts";
			// 
			// numMaxNumberOfPostsToFetch
			// 
			this.numMaxNumberOfPostsToFetch.Location = new System.Drawing.Point(62, 20);
			this.numMaxNumberOfPostsToFetch.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			this.numMaxNumberOfPostsToFetch.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numMaxNumberOfPostsToFetch.Name = "numMaxNumberOfPostsToFetch";
			this.numMaxNumberOfPostsToFetch.Size = new System.Drawing.Size(120, 20);
			this.numMaxNumberOfPostsToFetch.TabIndex = 15;
			this.numMaxNumberOfPostsToFetch.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// rdoGetPosts
			// 
			this.rdoGetPosts.AutoSize = true;
			this.rdoGetPosts.GroupName = "group1";
			this.rdoGetPosts.Location = new System.Drawing.Point(9, 0);
			this.rdoGetPosts.Name = "rdoGetPosts";
			this.rdoGetPosts.Size = new System.Drawing.Size(70, 17);
			this.rdoGetPosts.TabIndex = 0;
			this.rdoGetPosts.TabStop = true;
			this.rdoGetPosts.Text = "Get posts";
			this.rdoGetPosts.UseVisualStyleBackColor = true;
			this.rdoGetPosts.Click += new System.EventHandler(this.RadioButton_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 22);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(50, 13);
			this.label6.TabIndex = 0;
			this.label6.Text = "Number: ";
			// 
			// btnProcessComments
			// 
			this.btnProcessComments.Location = new System.Drawing.Point(499, 642);
			this.btnProcessComments.Name = "btnProcessComments";
			this.btnProcessComments.Size = new System.Drawing.Size(112, 23);
			this.btnProcessComments.TabIndex = 11;
			this.btnProcessComments.Text = "Process comments";
			this.btnProcessComments.UseVisualStyleBackColor = true;
			this.btnProcessComments.Click += new System.EventHandler(this.btnProcessComments_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 647);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(48, 13);
			this.label4.TabIndex = 10;
			this.label4.Text = "Progress";
			// 
			// progressBarComments
			// 
			this.progressBarComments.Location = new System.Drawing.Point(66, 642);
			this.progressBarComments.MarqueeAnimationSpeed = 0;
			this.progressBarComments.Name = "progressBarComments";
			this.progressBarComments.Size = new System.Drawing.Size(427, 23);
			this.progressBarComments.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
			this.progressBarComments.TabIndex = 9;
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(66, 613);
			this.progressBar1.MarqueeAnimationSpeed = 0;
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(427, 23);
			this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
			this.progressBar1.TabIndex = 8;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(499, 584);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(112, 23);
			this.button2.TabIndex = 7;
			this.button2.Text = "Browse";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(66, 586);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(427, 20);
			this.textBox2.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 589);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(26, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "File:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 618);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Progress";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(499, 613);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(112, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "Process";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Query:";
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.Filter = "Text files (*.txt)|*.txt";
			// 
			// progressBar
			// 
			this.progressBar.Location = new System.Drawing.Point(6, 299);
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(605, 23);
			this.progressBar.Step = 1;
			this.progressBar.TabIndex = 15;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(627, 686);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Padding = new System.Windows.Forms.Padding(5);
			this.Text = "Form1";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numMinimumCommenLength)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numMaxNumberOfCommentsPerPostToFetch)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numMaxNumberOfCommentsToFetch)).EndInit();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numMaxNumberOfPostsToFetch)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox txtUrl;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Button btnProcessComments;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ProgressBar progressBarComments;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.NumericUpDown numMaxNumberOfCommentsToFetch;
		private System.Windows.Forms.NumericUpDown numMaxNumberOfPostsToFetch;
		private System.Windows.Forms.NumericUpDown numMaxNumberOfCommentsPerPostToFetch;
		private System.Windows.Forms.Label label8;
		private FacebookWebCrawler.Controls.RadioButton rdoGetComments;
		private FacebookWebCrawler.Controls.RadioButton rdoGetPosts;
		private System.Windows.Forms.CheckBox cbxGroupByAuthor;
		private System.Windows.Forms.Button btnBrowseFolder;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textboxFolderPath;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.Button btnProcess;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.NumericUpDown numMinimumCommenLength;
		private System.Windows.Forms.ProgressBar progressBar;
	}
}

