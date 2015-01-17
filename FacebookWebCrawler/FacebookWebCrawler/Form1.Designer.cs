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
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.button2 = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.progressBarComments = new System.Windows.Forms.ProgressBar();
			this.label4 = new System.Windows.Forms.Label();
			this.btnProcessComments = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtUrl
			// 
			this.txtUrl.Location = new System.Drawing.Point(56, 19);
			this.txtUrl.Name = "txtUrl";
			this.txtUrl.Size = new System.Drawing.Size(551, 20);
			this.txtUrl.TabIndex = 0;
			// 
			// groupBox1
			// 
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
			this.groupBox1.Size = new System.Drawing.Size(615, 156);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Action";
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(66, 92);
			this.progressBar1.MarqueeAnimationSpeed = 0;
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(427, 23);
			this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
			this.progressBar1.TabIndex = 8;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(499, 43);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(108, 23);
			this.button2.TabIndex = 7;
			this.button2.Text = "Browse";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(56, 45);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(440, 20);
			this.textBox2.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 48);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(26, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "File:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 97);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Progress";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(499, 92);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(108, 23);
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
			// progressBarComments
			// 
			this.progressBarComments.Location = new System.Drawing.Point(66, 121);
			this.progressBarComments.MarqueeAnimationSpeed = 0;
			this.progressBarComments.Name = "progressBarComments";
			this.progressBarComments.Size = new System.Drawing.Size(427, 23);
			this.progressBarComments.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
			this.progressBarComments.TabIndex = 9;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 126);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(48, 13);
			this.label4.TabIndex = 10;
			this.label4.Text = "Progress";
			// 
			// btnProcessComments
			// 
			this.btnProcessComments.Location = new System.Drawing.Point(499, 121);
			this.btnProcessComments.Name = "btnProcessComments";
			this.btnProcessComments.Size = new System.Drawing.Size(108, 23);
			this.btnProcessComments.TabIndex = 11;
			this.btnProcessComments.Text = "Process comments";
			this.btnProcessComments.UseVisualStyleBackColor = true;
			this.btnProcessComments.Click += new System.EventHandler(this.btnProcessComments_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(625, 166);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.Padding = new System.Windows.Forms.Padding(5);
			this.Text = "Form1";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
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
	}
}

