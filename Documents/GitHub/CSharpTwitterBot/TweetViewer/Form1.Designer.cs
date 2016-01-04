namespace TweetViewer
{
    partial class TwitterWindow
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
            this.tweetList = new System.Windows.Forms.ListBox();
            this.followerList = new System.Windows.Forms.ListBox();
            this.tweetSearch = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tweetList
            // 
            this.tweetList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tweetList.FormattingEnabled = true;
            this.tweetList.ItemHeight = 16;
            this.tweetList.Location = new System.Drawing.Point(146, 61);
            this.tweetList.Name = "tweetList";
            this.tweetList.Size = new System.Drawing.Size(506, 388);
            this.tweetList.TabIndex = 0;
            // 
            // followerList
            // 
            this.followerList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.followerList.FormattingEnabled = true;
            this.followerList.ItemHeight = 16;
            this.followerList.Location = new System.Drawing.Point(12, 61);
            this.followerList.Name = "followerList";
            this.followerList.Size = new System.Drawing.Size(128, 388);
            this.followerList.TabIndex = 1;
            // 
            // tweetSearch
            // 
            this.tweetSearch.Location = new System.Drawing.Point(93, 21);
            this.tweetSearch.Name = "tweetSearch";
            this.tweetSearch.Size = new System.Drawing.Size(357, 22);
            this.tweetSearch.TabIndex = 2;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(12, 20);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 3;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // TwitterWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(664, 461);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.tweetSearch);
            this.Controls.Add(this.followerList);
            this.Controls.Add(this.tweetList);
            this.Name = "TwitterWindow";
            this.Text = "Tweet Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox tweetList;
        private System.Windows.Forms.ListBox followerList;
        private System.Windows.Forms.TextBox tweetSearch;
        private System.Windows.Forms.Button searchBtn;
    }
}

