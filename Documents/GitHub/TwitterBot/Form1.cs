using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LinqToTwitter;
using System.Text.RegularExpressions;

namespace TwitterBot
{
    public partial class Form1 : Form
    {
        private SingleUserAuthorizer authorizedUser = new SingleUserAuthorizer
        {
            CredentialStore = new SingleUserInMemoryCredentialStore
            {
                ConsumerKey = "xA5ys7Dz394wJDsAVgODqdJkv",
                ConsumerSecret = "Hesi9B00HC1Xyn4Gh2frl0e8ypwb3dMkUuXJ7fNcT3T3duF1o6",
                AccessToken = "2782802389-dwgmjoZwBcnSZQeDVJvpp4XJxV4CZHk1aoS7xDh",
                AccessTokenSecret = "v3xSuJKU00RwGhlbZ5mCtQRTO4YsSN2QDCODAH3LCZKg8"

            }
        };
        private List<Status> currentTweets;
        private void GetRecent200()
        {
            var twitterContext = new TwitterContext(authorizedUser);
            var tweets = from tweet in twitterContext.Status where tweet.Type == StatusType.Home && tweet.Count select tweet;

            currentTweets = tweets.ToList();
        }
        public Form1()
        {
            InitializeComponent();
            GetRecent200();
            tweetList.Items.Clear();
            currentTweets.ForEach(tweet => tweetList.Items.Add(tweet.Text));

        }

    }
}
