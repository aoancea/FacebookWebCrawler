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
			System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            ".*defect.*",
            "bug"}, -1);
			System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "2",
            ".*problem.*",
            "bug"}, -1);
			System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            ".*defect.*",
            "bug"}, -1);
			System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new string[] {
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
			this.progressBarPages = new System.Windows.Forms.ProgressBar();
			this.btnStart = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.fldrBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.txtProgressCount = new System.Windows.Forms.Label();
			this.tbxRequestsRemaining = new System.Windows.Forms.TextBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.tbxTimeAtLeast = new System.Windows.Forms.TextBox();
			this.cbxTimeAtLeast = new System.Windows.Forms.CheckBox();
			this.dtmOnlyAfterDate = new System.Windows.Forms.DateTimePicker();
			this.cbxOnlyAfterDate = new System.Windows.Forms.CheckBox();
			this.tbxLabelOneOf = new System.Windows.Forms.TextBox();
			this.cbxLabelOneOf = new System.Windows.Forms.CheckBox();
			this.tbxLengthAtLeast = new System.Windows.Forms.TextBox();
			this.cbxLengthAtLeast = new System.Windows.Forms.CheckBox();
			this.btnRemoveReplaceToken = new System.Windows.Forms.Button();
			this.btnAddReplaceToken = new System.Windows.Forms.Button();
			this.lstViewTextReplace = new System.Windows.Forms.ListView();
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.cbxReplaceTokens = new System.Windows.Forms.CheckBox();
			this.tbxTokensToRemove = new System.Windows.Forms.TextBox();
			this.cbxRemoveTokens = new System.Windows.Forms.CheckBox();
			this.cbxRemoveCode = new System.Windows.Forms.CheckBox();
			this.cbxRemoveLinks = new System.Windows.Forms.CheckBox();
			this.cbxFetchCommits = new System.Windows.Forms.CheckBox();
			this.lblRepeatTitle = new System.Windows.Forms.Label();
			this.tbxRepeatTitle = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// tbxRepoOwner
			// 
			this.tbxRepoOwner.Location = new System.Drawing.Point(82, 128);
			this.tbxRepoOwner.Name = "tbxRepoOwner";
			this.tbxRepoOwner.Size = new System.Drawing.Size(115, 20);
			this.tbxRepoOwner.TabIndex = 0;
			this.tbxRepoOwner.Text = "angular";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 131);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Repo owner:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(8, 157);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Save location:";
			// 
			// tbxFolderPath
			// 
			this.tbxFolderPath.Location = new System.Drawing.Point(82, 154);
			this.tbxFolderPath.Name = "tbxFolderPath";
			this.tbxFolderPath.Size = new System.Drawing.Size(244, 20);
			this.tbxFolderPath.TabIndex = 3;
			// 
			// btnBrowseFolder
			// 
			this.btnBrowseFolder.Location = new System.Drawing.Point(332, 152);
			this.btnBrowseFolder.Name = "btnBrowseFolder";
			this.btnBrowseFolder.Size = new System.Drawing.Size(57, 23);
			this.btnBrowseFolder.TabIndex = 4;
			this.btnBrowseFolder.Text = "Browse";
			this.btnBrowseFolder.UseVisualStyleBackColor = true;
			this.btnBrowseFolder.Click += new System.EventHandler(this.btnBrowseFolder_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.tbxRepeatTitle);
			this.groupBox1.Controls.Add(this.lblRepeatTitle);
			this.groupBox1.Controls.Add(this.cbxFetchCommits);
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
			this.groupBox1.Size = new System.Drawing.Size(399, 281);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Main options";
			// 
			// tbxAccessToken
			// 
			this.tbxAccessToken.Location = new System.Drawing.Point(11, 38);
			this.tbxAccessToken.Multiline = true;
			this.tbxAccessToken.Name = "tbxAccessToken";
			this.tbxAccessToken.Size = new System.Drawing.Size(378, 84);
			this.tbxAccessToken.TabIndex = 17;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(8, 22);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(144, 13);
			this.label5.TabIndex = 16;
			this.label5.Text = "Access tokens (one per line):";
			// 
			// tbxRepoName
			// 
			this.tbxRepoName.Location = new System.Drawing.Point(274, 128);
			this.tbxRepoName.Name = "tbxRepoName";
			this.tbxRepoName.Size = new System.Drawing.Size(115, 20);
			this.tbxRepoName.TabIndex = 15;
			this.tbxRepoName.Text = "angular.js";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(203, 131);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(65, 13);
			this.label4.TabIndex = 14;
			this.label4.Text = "Repo name:";
			// 
			// cbxFetchPullRequests
			// 
			this.cbxFetchPullRequests.AutoSize = true;
			this.cbxFetchPullRequests.Location = new System.Drawing.Point(254, 208);
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
			this.cbxFetchClosedIssues.Location = new System.Drawing.Point(129, 208);
			this.cbxFetchClosedIssues.Name = "cbxFetchClosedIssues";
			this.cbxFetchClosedIssues.Size = new System.Drawing.Size(119, 17);
			this.cbxFetchClosedIssues.TabIndex = 11;
			this.cbxFetchClosedIssues.Text = "Fetch closed issues";
			this.cbxFetchClosedIssues.UseVisualStyleBackColor = true;
			this.cbxFetchClosedIssues.CheckedChanged += new System.EventHandler(this.cbxFetchClosedIssues_CheckedChanged);
			// 
			// cbxFetchOpenIssues
			// 
			this.cbxFetchOpenIssues.AutoSize = true;
			this.cbxFetchOpenIssues.Checked = true;
			this.cbxFetchOpenIssues.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbxFetchOpenIssues.Location = new System.Drawing.Point(11, 208);
			this.cbxFetchOpenIssues.Name = "cbxFetchOpenIssues";
			this.cbxFetchOpenIssues.Size = new System.Drawing.Size(112, 17);
			this.cbxFetchOpenIssues.TabIndex = 10;
			this.cbxFetchOpenIssues.Text = "Fetch open issues";
			this.cbxFetchOpenIssues.UseVisualStyleBackColor = true;
			this.cbxFetchOpenIssues.CheckedChanged += new System.EventHandler(this.cbxFetchOpenIssues_CheckedChanged);
			// 
			// cbxConcatCommentsToIssueText
			// 
			this.cbxConcatCommentsToIssueText.AutoSize = true;
			this.cbxConcatCommentsToIssueText.Location = new System.Drawing.Point(129, 185);
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
			this.cbxFetchComments.Location = new System.Drawing.Point(11, 185);
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
			this.groupBox2.Location = new System.Drawing.Point(12, 299);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(399, 240);
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
			this.rdoOnlyConsiderFirst.Location = new System.Drawing.Point(6, 214);
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
			this.btnRemoveLabelOverride.Location = new System.Drawing.Point(328, 24);
			this.btnRemoveLabelOverride.Name = "btnRemoveLabelOverride";
			this.btnRemoveLabelOverride.Size = new System.Drawing.Size(61, 23);
			this.btnRemoveLabelOverride.TabIndex = 10;
			this.btnRemoveLabelOverride.Text = "Remove";
			this.btnRemoveLabelOverride.UseVisualStyleBackColor = true;
			// 
			// btnAddLabelOverride
			// 
			this.btnAddLabelOverride.Location = new System.Drawing.Point(261, 24);
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
			listViewItem6.Tag = "";
			this.lstViewLabelOverride.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem5,
            listViewItem6});
			this.lstViewLabelOverride.Location = new System.Drawing.Point(6, 53);
			this.lstViewLabelOverride.Name = "lstViewLabelOverride";
			this.lstViewLabelOverride.Size = new System.Drawing.Size(383, 123);
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
			// progressBarPages
			// 
			this.progressBarPages.Location = new System.Drawing.Point(12, 545);
			this.progressBarPages.MarqueeAnimationSpeed = 0;
			this.progressBarPages.Name = "progressBarPages";
			this.progressBarPages.Size = new System.Drawing.Size(399, 23);
			this.progressBarPages.Step = 1;
			this.progressBarPages.TabIndex = 9;
			// 
			// btnStart
			// 
			this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnStart.Location = new System.Drawing.Point(12, 574);
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
			this.btnCancel.Location = new System.Drawing.Point(101, 574);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(83, 30);
			this.btnCancel.TabIndex = 15;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// txtProgressCount
			// 
			this.txtProgressCount.AutoSize = true;
			this.txtProgressCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtProgressCount.Location = new System.Drawing.Point(194, 552);
			this.txtProgressCount.Name = "txtProgressCount";
			this.txtProgressCount.Size = new System.Drawing.Size(0, 13);
			this.txtProgressCount.TabIndex = 18;
			// 
			// tbxRequestsRemaining
			// 
			this.tbxRequestsRemaining.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbxRequestsRemaining.Location = new System.Drawing.Point(190, 580);
			this.tbxRequestsRemaining.Name = "tbxRequestsRemaining";
			this.tbxRequestsRemaining.ReadOnly = true;
			this.tbxRequestsRemaining.Size = new System.Drawing.Size(221, 20);
			this.tbxRequestsRemaining.TabIndex = 19;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.tbxTimeAtLeast);
			this.groupBox3.Controls.Add(this.cbxTimeAtLeast);
			this.groupBox3.Controls.Add(this.dtmOnlyAfterDate);
			this.groupBox3.Controls.Add(this.cbxOnlyAfterDate);
			this.groupBox3.Controls.Add(this.tbxLabelOneOf);
			this.groupBox3.Controls.Add(this.cbxLabelOneOf);
			this.groupBox3.Controls.Add(this.tbxLengthAtLeast);
			this.groupBox3.Controls.Add(this.cbxLengthAtLeast);
			this.groupBox3.Controls.Add(this.btnRemoveReplaceToken);
			this.groupBox3.Controls.Add(this.btnAddReplaceToken);
			this.groupBox3.Controls.Add(this.lstViewTextReplace);
			this.groupBox3.Controls.Add(this.cbxReplaceTokens);
			this.groupBox3.Controls.Add(this.tbxTokensToRemove);
			this.groupBox3.Controls.Add(this.cbxRemoveTokens);
			this.groupBox3.Controls.Add(this.cbxRemoveCode);
			this.groupBox3.Controls.Add(this.cbxRemoveLinks);
			this.groupBox3.Location = new System.Drawing.Point(417, 12);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(272, 588);
			this.groupBox3.TabIndex = 18;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Filtering options";
			// 
			// tbxTimeAtLeast
			// 
			this.tbxTimeAtLeast.Location = new System.Drawing.Point(101, 38);
			this.tbxTimeAtLeast.Name = "tbxTimeAtLeast";
			this.tbxTimeAtLeast.Size = new System.Drawing.Size(165, 20);
			this.tbxTimeAtLeast.TabIndex = 28;
			// 
			// cbxTimeAtLeast
			// 
			this.cbxTimeAtLeast.AutoSize = true;
			this.cbxTimeAtLeast.Location = new System.Drawing.Point(6, 41);
			this.cbxTimeAtLeast.Name = "cbxTimeAtLeast";
			this.cbxTimeAtLeast.Size = new System.Drawing.Size(89, 17);
			this.cbxTimeAtLeast.TabIndex = 27;
			this.cbxTimeAtLeast.Text = "Time at least:";
			this.cbxTimeAtLeast.UseVisualStyleBackColor = true;
			// 
			// dtmOnlyAfterDate
			// 
			this.dtmOnlyAfterDate.Location = new System.Drawing.Point(6, 519);
			this.dtmOnlyAfterDate.Name = "dtmOnlyAfterDate";
			this.dtmOnlyAfterDate.Size = new System.Drawing.Size(260, 20);
			this.dtmOnlyAfterDate.TabIndex = 26;
			// 
			// cbxOnlyAfterDate
			// 
			this.cbxOnlyAfterDate.AutoSize = true;
			this.cbxOnlyAfterDate.Location = new System.Drawing.Point(6, 497);
			this.cbxOnlyAfterDate.Name = "cbxOnlyAfterDate";
			this.cbxOnlyAfterDate.Size = new System.Drawing.Size(116, 17);
			this.cbxOnlyAfterDate.TabIndex = 25;
			this.cbxOnlyAfterDate.Text = "Get only after date:";
			this.cbxOnlyAfterDate.UseVisualStyleBackColor = true;
			// 
			// tbxLabelOneOf
			// 
			this.tbxLabelOneOf.Location = new System.Drawing.Point(6, 407);
			this.tbxLabelOneOf.Multiline = true;
			this.tbxLabelOneOf.Name = "tbxLabelOneOf";
			this.tbxLabelOneOf.Size = new System.Drawing.Size(260, 84);
			this.tbxLabelOneOf.TabIndex = 24;
			this.tbxLabelOneOf.Text = "bug\r\nproblem\r\ndefect";
			// 
			// cbxLabelOneOf
			// 
			this.cbxLabelOneOf.AutoSize = true;
			this.cbxLabelOneOf.Location = new System.Drawing.Point(6, 384);
			this.cbxLabelOneOf.Name = "cbxLabelOneOf";
			this.cbxLabelOneOf.Size = new System.Drawing.Size(133, 17);
			this.cbxLabelOneOf.TabIndex = 23;
			this.cbxLabelOneOf.Text = "Labels must be one of:";
			this.cbxLabelOneOf.UseVisualStyleBackColor = true;
			// 
			// tbxLengthAtLeast
			// 
			this.tbxLengthAtLeast.Location = new System.Drawing.Point(111, 349);
			this.tbxLengthAtLeast.Name = "tbxLengthAtLeast";
			this.tbxLengthAtLeast.Size = new System.Drawing.Size(155, 20);
			this.tbxLengthAtLeast.TabIndex = 18;
			// 
			// cbxLengthAtLeast
			// 
			this.cbxLengthAtLeast.AutoSize = true;
			this.cbxLengthAtLeast.Location = new System.Drawing.Point(6, 351);
			this.cbxLengthAtLeast.Name = "cbxLengthAtLeast";
			this.cbxLengthAtLeast.Size = new System.Drawing.Size(99, 17);
			this.cbxLengthAtLeast.TabIndex = 22;
			this.cbxLengthAtLeast.Text = "Length at least:";
			this.cbxLengthAtLeast.UseVisualStyleBackColor = true;
			// 
			// btnRemoveReplaceToken
			// 
			this.btnRemoveReplaceToken.Location = new System.Drawing.Point(73, 312);
			this.btnRemoveReplaceToken.Name = "btnRemoveReplaceToken";
			this.btnRemoveReplaceToken.Size = new System.Drawing.Size(61, 23);
			this.btnRemoveReplaceToken.TabIndex = 14;
			this.btnRemoveReplaceToken.Text = "Remove";
			this.btnRemoveReplaceToken.UseVisualStyleBackColor = true;
			// 
			// btnAddReplaceToken
			// 
			this.btnAddReplaceToken.Location = new System.Drawing.Point(6, 312);
			this.btnAddReplaceToken.Name = "btnAddReplaceToken";
			this.btnAddReplaceToken.Size = new System.Drawing.Size(61, 23);
			this.btnAddReplaceToken.TabIndex = 14;
			this.btnAddReplaceToken.Text = "Add";
			this.btnAddReplaceToken.UseVisualStyleBackColor = true;
			// 
			// lstViewTextReplace
			// 
			this.lstViewTextReplace.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
			this.lstViewTextReplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstViewTextReplace.FullRowSelect = true;
			this.lstViewTextReplace.GridLines = true;
			listViewItem8.Tag = "";
			this.lstViewTextReplace.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem7,
            listViewItem8});
			this.lstViewTextReplace.Location = new System.Drawing.Point(6, 208);
			this.lstViewTextReplace.Name = "lstViewTextReplace";
			this.lstViewTextReplace.Size = new System.Drawing.Size(260, 98);
			this.lstViewTextReplace.TabIndex = 14;
			this.lstViewTextReplace.UseCompatibleStateImageBehavior = false;
			this.lstViewTextReplace.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "#";
			this.columnHeader4.Width = 40;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Original Text";
			this.columnHeader5.Width = 120;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Replace Text";
			this.columnHeader6.Width = 90;
			// 
			// cbxReplaceTokens
			// 
			this.cbxReplaceTokens.AutoSize = true;
			this.cbxReplaceTokens.Location = new System.Drawing.Point(6, 185);
			this.cbxReplaceTokens.Name = "cbxReplaceTokens";
			this.cbxReplaceTokens.Size = new System.Drawing.Size(220, 17);
			this.cbxReplaceTokens.TabIndex = 21;
			this.cbxReplaceTokens.Text = "Replace tokens in text (regex supported):";
			this.cbxReplaceTokens.UseVisualStyleBackColor = true;
			// 
			// tbxTokensToRemove
			// 
			this.tbxTokensToRemove.Location = new System.Drawing.Point(6, 87);
			this.tbxTokensToRemove.Multiline = true;
			this.tbxTokensToRemove.Name = "tbxTokensToRemove";
			this.tbxTokensToRemove.Size = new System.Drawing.Size(260, 84);
			this.tbxTokensToRemove.TabIndex = 18;
			this.tbxTokensToRemove.Text = "$\r\n<\r\n>\r\nfor";
			// 
			// cbxRemoveTokens
			// 
			this.cbxRemoveTokens.AutoSize = true;
			this.cbxRemoveTokens.Location = new System.Drawing.Point(6, 64);
			this.cbxRemoveTokens.Name = "cbxRemoveTokens";
			this.cbxRemoveTokens.Size = new System.Drawing.Size(147, 17);
			this.cbxRemoveTokens.TabIndex = 20;
			this.cbxRemoveTokens.Text = "Remove tokens from text:";
			this.cbxRemoveTokens.UseVisualStyleBackColor = true;
			// 
			// cbxRemoveCode
			// 
			this.cbxRemoveCode.AutoSize = true;
			this.cbxRemoveCode.Location = new System.Drawing.Point(102, 18);
			this.cbxRemoveCode.Name = "cbxRemoveCode";
			this.cbxRemoveCode.Size = new System.Drawing.Size(93, 17);
			this.cbxRemoveCode.TabIndex = 19;
			this.cbxRemoveCode.Text = "Remove code";
			this.cbxRemoveCode.UseVisualStyleBackColor = true;
			// 
			// cbxRemoveLinks
			// 
			this.cbxRemoveLinks.AutoSize = true;
			this.cbxRemoveLinks.Location = new System.Drawing.Point(6, 18);
			this.cbxRemoveLinks.Name = "cbxRemoveLinks";
			this.cbxRemoveLinks.Size = new System.Drawing.Size(90, 17);
			this.cbxRemoveLinks.TabIndex = 18;
			this.cbxRemoveLinks.Text = "Remove links";
			this.cbxRemoveLinks.UseVisualStyleBackColor = true;
			// 
			// cbxFetchCommits
			// 
			this.cbxFetchCommits.AutoSize = true;
			this.cbxFetchCommits.Checked = true;
			this.cbxFetchCommits.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbxFetchCommits.Location = new System.Drawing.Point(11, 231);
			this.cbxFetchCommits.Name = "cbxFetchCommits";
			this.cbxFetchCommits.Size = new System.Drawing.Size(94, 17);
			this.cbxFetchCommits.TabIndex = 18;
			this.cbxFetchCommits.Text = "Fetch commits";
			this.cbxFetchCommits.UseVisualStyleBackColor = true;
			// 
			// lblRepeatTitle
			// 
			this.lblRepeatTitle.AutoSize = true;
			this.lblRepeatTitle.Location = new System.Drawing.Point(8, 255);
			this.lblRepeatTitle.Name = "lblRepeatTitle";
			this.lblRepeatTitle.Size = new System.Drawing.Size(64, 13);
			this.lblRepeatTitle.TabIndex = 19;
			this.lblRepeatTitle.Text = "Repeat title:";
			// 
			// tbxRepeatTitle
			// 
			this.tbxRepeatTitle.Location = new System.Drawing.Point(78, 252);
			this.tbxRepeatTitle.Name = "tbxRepeatTitle";
			this.tbxRepeatTitle.Size = new System.Drawing.Size(45, 20);
			this.tbxRepeatTitle.TabIndex = 20;
			this.tbxRepeatTitle.Text = "3";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(701, 610);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.tbxRequestsRemaining);
			this.Controls.Add(this.txtProgressCount);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.progressBarPages);
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
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

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
		private System.Windows.Forms.ProgressBar progressBarPages;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.CheckBox cbxFetchPullRequests;
		private System.Windows.Forms.CheckBox cbxFetchClosedIssues;
		private System.Windows.Forms.CheckBox cbxFetchOpenIssues;
		private System.Windows.Forms.TextBox tbxRepoName;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tbxAccessToken;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.FolderBrowserDialog fldrBrowserDialog;
		private System.Windows.Forms.Label txtProgressCount;
		private System.Windows.Forms.TextBox tbxRequestsRemaining;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.CheckBox cbxRemoveCode;
		private System.Windows.Forms.CheckBox cbxRemoveLinks;
		private System.Windows.Forms.ListView lstViewTextReplace;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.CheckBox cbxReplaceTokens;
		private System.Windows.Forms.TextBox tbxTokensToRemove;
		private System.Windows.Forms.CheckBox cbxRemoveTokens;
		private System.Windows.Forms.Button btnRemoveReplaceToken;
		private System.Windows.Forms.Button btnAddReplaceToken;
		private System.Windows.Forms.TextBox tbxLabelOneOf;
		private System.Windows.Forms.CheckBox cbxLabelOneOf;
		private System.Windows.Forms.TextBox tbxLengthAtLeast;
		private System.Windows.Forms.CheckBox cbxLengthAtLeast;
		private System.Windows.Forms.DateTimePicker dtmOnlyAfterDate;
		private System.Windows.Forms.CheckBox cbxOnlyAfterDate;
		private System.Windows.Forms.TextBox tbxTimeAtLeast;
		private System.Windows.Forms.CheckBox cbxTimeAtLeast;
		private System.Windows.Forms.TextBox tbxRepeatTitle;
		private System.Windows.Forms.Label lblRepeatTitle;
		private System.Windows.Forms.CheckBox cbxFetchCommits;
	}
}

