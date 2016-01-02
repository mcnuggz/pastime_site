namespace TwitterBot
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
            this.searchTweets = new System.Windows.Forms.TextBox();
            this.searchTweetsBtn = new System.Windows.Forms.Button();
            this.followerList = new System.Windows.Forms.ListBox();
            this.tweetList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // searchTweets
            // 
            this.searchTweets.Location = new System.Drawing.Point(107, 28);
            this.searchTweets.Name = "searchTweets";
            this.searchTweets.Size = new System.Drawing.Size(395, 22);
            this.searchTweets.TabIndex = 0;
            // 
            // searchTweetsBtn
            // 
            this.searchTweetsBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.searchTweetsBtn.FlatAppearance.BorderSize = 3;
            this.searchTweetsBtn.Location = new System.Drawing.Point(12, 28);
            this.searchTweetsBtn.Name = "searchTweetsBtn";
            this.searchTweetsBtn.Size = new System.Drawing.Size(75, 23);
            this.searchTweetsBtn.TabIndex = 1;
            this.searchTweetsBtn.Text = "Search";
            this.searchTweetsBtn.UseVisualStyleBackColor = true;
            this.searchTweetsBtn.Click += new System.EventHandler(this.searchTweetsBtn_Click);
            // 
            // followerList
            // 
            this.followerList.FormattingEnabled = true;
            this.followerList.ItemHeight = 16;
            this.followerList.Location = new System.Drawing.Point(12, 65);
            this.followerList.Name = "followerList";
            this.followerList.Size = new System.Drawing.Size(146, 468);
            this.followerList.TabIndex = 2;
            // 
            // tweetList
            // 
            this.tweetList.FormattingEnabled = true;
            this.tweetList.ItemHeight = 16;
            this.tweetList.Location = new System.Drawing.Point(164, 65);
            this.tweetList.Name = "tweetList";
            this.tweetList.Size = new System.Drawing.Size(746, 468);
            this.tweetList.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(922, 551);
            this.Controls.Add(this.tweetList);
            this.Controls.Add(this.followerList);
            this.Controls.Add(this.searchTweetsBtn);
            this.Controls.Add(this.searchTweets);
            this.Name = "Form1";
            this.Text = "Twitter List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchTweets;
        private System.Windows.Forms.Button searchTweetsBtn;
        private System.Windows.Forms.ListBox followerList;
        private System.Windows.Forms.ListBox tweetList;
    }
}

