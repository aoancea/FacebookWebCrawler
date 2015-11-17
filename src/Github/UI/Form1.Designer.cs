namespace Crawler.Github.UI
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
			System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            ".*defect.*",
            "bug"}, -1);
			System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "2",
            ".*problem.*",
            "bug"}, -1);
			this.tbxRepoOwner = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tbxFolderPath = new System.Windows.Forms.TextBox();
			this.btnBrowseFolder = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tbxAccessToken = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.tbxRepoName = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.cbxFetchPullRequests = new System.Windows.Forms.CheckBox();
			this.cbxFetchClosedIssues = new System.Windows.Forms.CheckBox();
			this.cbxFetchOpenIssues = new System.Windows.Forms.CheckBox();
			this.cbxConcatCommentsToIssueText = new System.Windows.Forms.CheckBox();
			this.cbxFetchComments = new System.Windows.Forms.CheckBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.rdoOnlyConsiderFirst = new System.Windows.Forms.RadioButton();
			this.rdoDuplicateForEachLabel = new System.Windows.Forms.RadioButton();
			this.btnRemoveLabelOverride = new System.Windows.Forms.Button();
			this.btnAddLabelOverride = new System.Windows.Forms.Button();
			this.lstViewLabelOverride = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.progressBar = new System.Windows.Forms.ProgressBar();
			this.btnStart = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tbxRepoOwner
			// 
			this.tbxRepoOwner.Location = new System.Drawing.Point(82, 46);
			this.tbxRepoOwner.Name = "tbxRepoOwner";
			this.tbxRepoOwner.Size = new System.Drawing.Size(189, 20);
			this.tbxRepoOwner.TabIndex = 0;
			this.tbxRepoOwner.Text = "angular";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 49);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Repo owner:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(8, 80);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Save location:";
			// 
			// tbxFolderPath
			// 
			this.tbxFolderPath.Location = new System.Drawing.Point(82, 77);
			this.tbxFolderPath.Name = "tbxFolderPath";
			this.tbxFolderPath.Size = new System.Drawing.Size(428, 20);
			this.tbxFolderPath.TabIndex = 3;
			// 
			// btnBrowseFolder
			// 
			this.btnBrowseFolder.Location = new System.Drawing.Point(516, 75);
			this.btnBrowseFolder.Name = "btnBrowseFolder";
			this.btnBrowseFolder.Size = new System.Drawing.Size(61, 23);
			this.btnBrowseFolder.TabIndex = 4;
			this.btnBrowseFolder.Text = "Browse";
			this.btnBrowseFolder.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.tbxAccessToken);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.tbxRepoName);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.cbxFetchPullRequests);
			this.groupBox1.Controls.Add(this.cbxFetchClosedIssues);
			this.groupBox1.Controls.Add(this.cbxFetchOpenIssues);
			this.groupBox1.Controls.Add(this.cbxConcatCommentsToIssueText);
			this.groupBox1.Controls.Add(this.cbxFetchComments);
			this.groupBox1.Controls.Add(this.btnBrowseFolder);
			this.groupBox1.Controls.Add(this.tbxRepoOwner);
			this.groupBox1.Controls.Add(this.tbxFolderPath);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(583, 148);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Main options";
			// 
			// tbxAccessToken
			// 
			this.tbxAccessToken.Location = new System.Drawing.Point(82, 19);
			this.tbxAccessToken.Name = "tbxAccessToken";
			this.tbxAccessToken.Size = new System.Drawing.Size(495, 20);
			this.tbxAccessToken.TabIndex = 17;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(8, 22);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(75, 13);
			this.label5.TabIndex = 16;
			this.label5.Text = "Access token:";
			// 
			// tbxRepoName
			// 
			this.tbxRepoName.Location = new System.Drawing.Point(388, 46);
			this.tbxRepoName.Name = "tbxRepoName";
			this.tbxRepoName.Size = new System.Drawing.Size(189, 20);
			this.tbxRepoName.TabIndex = 15;
			this.tbxRepoName.Text = "angular.js";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(310, 49);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(65, 13);
			this.label4.TabIndex = 14;
			this.label4.Text = "Repo name:";
			// 
			// cbxFetchPullRequests
			// 
			this.cbxFetchPullRequests.AutoSize = true;
			this.cbxFetchPullRequests.Location = new System.Drawing.Point(254, 126);
			this.cbxFetchPullRequests.Name = "cbxFetchPullRequests";
			this.cbxFetchPullRequests.Size = new System.Drawing.Size(115, 17);
			this.cbxFetchPullRequests.TabIndex = 12;
			this.cbxFetchPullRequests.Text = "Fetch pull requests";
			this.cbxFetchPullRequests.UseVisualStyleBackColor = true;
			// 
			// cbxFetchClosedIssues
			// 
			this.cbxFetchClosedIssues.AutoSize = true;
			this.cbxFetchClosedIssues.Checked = true;
			this.cbxFetchClosedIssues.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbxFetchClosedIssues.Location = new System.Drawing.Point(129, 126);
			this.cbxFetchClosedIssues.Name = "cbxFetchClosedIssues";
			this.cbxFetchClosedIssues.Size = new System.Drawing.Size(119, 17);
			this.cbxFetchClosedIssues.TabIndex = 11;
			this.cbxFetchClosedIssues.Text = "Fetch closed issues";
			this.cbxFetchClosedIssues.UseVisualStyleBackColor = true;
			// 
			// cbxFetchOpenIssues
			// 
			this.cbxFetchOpenIssues.AutoSize = true;
			this.cbxFetchOpenIssues.Checked = true;
			this.cbxFetchOpenIssues.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbxFetchOpenIssues.Location = new System.Drawing.Point(11, 126);
			this.cbxFetchOpenIssues.Name = "cbxFetchOpenIssues";
			this.cbxFetchOpenIssues.Size = new System.Drawing.Size(112, 17);
			this.cbxFetchOpenIssues.TabIndex = 10;
			this.cbxFetchOpenIssues.Text = "Fetch open issues";
			this.cbxFetchOpenIssues.UseVisualStyleBackColor = true;
			// 
			// cbxConcatCommentsToIssueText
			// 
			this.cbxConcatCommentsToIssueText.AutoSize = true;
			this.cbxConcatCommentsToIssueText.Location = new System.Drawing.Point(121, 103);
			this.cbxConcatCommentsToIssueText.Name = "cbxConcatCommentsToIssueText";
			this.cbxConcatCommentsToIssueText.Size = new System.Drawing.Size(197, 17);
			this.cbxConcatCommentsToIssueText.TabIndex = 7;
			this.cbxConcatCommentsToIssueText.Text = "Concatenate comments to issue text";
			this.cbxConcatCommentsToIssueText.UseVisualStyleBackColor = true;
			// 
			// cbxFetchComments
			// 
			this.cbxFetchComments.AutoSize = true;
			this.cbxFetchComments.Checked = true;
			this.cbxFetchComments.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbxFetchComments.Location = new System.Drawing.Point(11, 103);
			this.cbxFetchComments.Name = "cbxFetchComments";
			this.cbxFetchComments.Size = new System.Drawing.Size(104, 17);
			this.cbxFetchComments.TabIndex = 6;
			this.cbxFetchComments.Text = "Fetch comments";
			this.cbxFetchComments.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.rdoOnlyConsiderFirst);
			this.groupBox2.Controls.Add(this.rdoDuplicateForEachLabel);
			this.groupBox2.Controls.Add(this.btnRemoveLabelOverride);
			this.groupBox2.Controls.Add(this.btnAddLabelOverride);
			this.groupBox2.Controls.Add(this.lstViewLabelOverride);
			this.groupBox2.Location = new System.Drawing.Point(12, 168);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(583, 214);
			this.groupBox2.TabIndex = 8;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Label grouping options";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 31);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(167, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Label renaming (regex supported):";
			// 
			// rdoOnlyConsiderFirst
			// 
			this.rdoOnlyConsiderFirst.AutoSize = true;
			this.rdoOnlyConsiderFirst.Location = new System.Drawing.Point(313, 191);
			this.rdoOnlyConsiderFirst.Name = "rdoOnlyConsiderFirst";
			this.rdoOnlyConsiderFirst.Size = new System.Drawing.Size(266, 17);
			this.rdoOnlyConsiderFirst.TabIndex = 13;
			this.rdoOnlyConsiderFirst.Text = "If an issue has multiple labels, only consider the first";
			this.rdoOnlyConsiderFirst.UseVisualStyleBackColor = true;
			// 
			// rdoDuplicateForEachLabel
			// 
			this.rdoDuplicateForEachLabel.AutoSize = true;
			this.rdoDuplicateForEachLabel.Checked = true;
			this.rdoDuplicateForEachLabel.Location = new System.Drawing.Point(6, 191);
			this.rdoDuplicateForEachLabel.Name = "rdoDuplicateForEachLabel";
			this.rdoDuplicateForEachLabel.Size = new System.Drawing.Size(285, 17);
			this.rdoDuplicateForEachLabel.TabIndex = 12;
			this.rdoDuplicateForEachLabel.TabStop = true;
			this.rdoDuplicateForEachLabel.Text = "If an issue has multiple labels, duplicate it for each label";
			this.rdoDuplicateForEachLabel.UseVisualStyleBackColor = true;
			// 
			// btnRemoveLabelOverride
			// 
			this.btnRemoveLabelOverride.Location = new System.Drawing.Point(516, 26);
			this.btnRemoveLabelOverride.Name = "btnRemoveLabelOverride";
			this.btnRemoveLabelOverride.Size = new System.Drawing.Size(61, 23);
			this.btnRemoveLabelOverride.TabIndex = 10;
			this.btnRemoveLabelOverride.Text = "Remove";
			this.btnRemoveLabelOverride.UseVisualStyleBackColor = true;
			// 
			// btnAddLabelOverride
			// 
			this.btnAddLabelOverride.Location = new System.Drawing.Point(449, 26);
			this.btnAddLabelOverride.Name = "btnAddLabelOverride";
			this.btnAddLabelOverride.Size = new System.Drawing.Size(61, 23);
			this.btnAddLabelOverride.TabIndex = 8;
			this.btnAddLabelOverride.Text = "Add";
			this.btnAddLabelOverride.UseVisualStyleBackColor = true;
			// 
			// lstViewLabelOverride
			// 
			this.lstViewLabelOverride.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
			this.lstViewLabelOverride.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstViewLabelOverride.FullRowSelect = true;
			this.lstViewLabelOverride.GridLines = true;
			listViewItem2.Tag = "";
			this.lstViewLabelOverride.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
			this.lstViewLabelOverride.Location = new System.Drawing.Point(6, 53);
			this.lstViewLabelOverride.Name = "lstViewLabelOverride";
			this.lstViewLabelOverride.Size = new System.Drawing.Size(571, 123);
			this.lstViewLabelOverride.TabIndex = 9;
			this.lstViewLabelOverride.UseCompatibleStateImageBehavior = false;
			this.lstViewLabelOverride.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "#";
			this.columnHeader1.Width = 40;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Original Label Text";
			this.columnHeader2.Width = 120;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Rename to text";
			this.columnHeader3.Width = 120;
			// 
			// progressBar
			// 
			this.progressBar.Location = new System.Drawing.Point(12, 388);
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(583, 23);
			this.progressBar.TabIndex = 9;
			// 
			// btnStart
			// 
			this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnStart.Location = new System.Drawing.Point(12, 417);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(83, 30);
			this.btnStart.TabIndex = 14;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancel.Location = new System.Drawing.Point(101, 417);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(83, 30);
			this.btnCancel.TabIndex = 15;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(610, 452);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.progressBar);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.Text = "Form1";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox tbxRepoOwner;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbxFolderPath;
		private System.Windows.Forms.Button btnBrowseFolder;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox cbxConcatCommentsToIssueText;
		private System.Windows.Forms.CheckBox cbxFetchComments;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.RadioButton rdoOnlyConsiderFirst;
		private System.Windows.Forms.RadioButton rdoDuplicateForEachLabel;
		private System.Windows.Forms.Button btnRemoveLabelOverride;
		private System.Windows.Forms.Button btnAddLabelOverride;
		private System.Windows.Forms.ListView lstViewLabelOverride;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ProgressBar progressBar;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.CheckBox cbxFetchPullRequests;
		private System.Windows.Forms.CheckBox cbxFetchClosedIssues;
		private System.Windows.Forms.CheckBox cbxFetchOpenIssues;
		private System.Windows.Forms.TextBox tbxRepoName;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tbxAccessToken;
		private System.Windows.Forms.Label label5;
	}
}

