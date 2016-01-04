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

namespace TweetViewer
{
    public partial class TwitterWindow : Form
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

        private void GetRecent200()
        {
            var twitterContext = new TwitterContext(authorizedUser);
            var tweets = from tweet in twitterContext.Status
                         where tweet.Type == StatusType.Home &&
                         tweet.Count == 200
                         select tweet;

            currentTweets = tweets.ToList();
        }

        private List<Status> currentTweets;

        //form constructor
        public TwitterWindow()
        {
            InitializeComponent();
            GetRecent200();
            tweetList.Items.Clear();
            currentTweets.ForEach(tweet => tweetList.Items.Add(tweet.Text));
            GetSideBarList(GetFollowers()).ForEach(name => followerList.Items.Add(name));
        }

        private List<string> GetFollowers()
        {
            List<string> results = new List<string>();

            var twitterContext = new TwitterContext(authorizedUser);

            var temp = Enumerable.FirstOrDefault(from friend in twitterContext.Friendship
                                                 where friend.Type == FriendshipType.FollowersList &&
                                                 friend.ScreenName == "Bostato90" &&
                                                 friend.Count == 200
                                                 select friend);
            if (temp != null)
            {
                temp.Users.ToList().ForEach(user => results.Add(user.Name));

                while (temp != null && temp.CursorMovement.Next != 0)
                {
                    temp = Enumerable.FirstOrDefault(from friend in twitterContext.Friendship
                                                      where friend.Type == FriendshipType.FollowersList &&
                                                      friend.ScreenName == "Bostato90" &&
                                                      friend.Count == 200 &&
                                                      friend.Cursor == temp.CursorMovement.Next
                                                      select friend);
                    if (temp != null) temp.Users.ToList().ForEach(user => results.Add(user.Name));
                }
            }
            return results;
        }
        private List<string> GetSideBarList(List<string> inputNames)
        {
            List<string> results = new List<string>();
            foreach(string name in inputNames)
            {
                int tweetCount = currentTweets.Count(tweet => tweet.User.Name == name);
                if(tweetCount > 0)
                {
                    results.Add(string.Format("{0} ({1}", name, tweetCount));
                }
                else
                {
                    results.Add(string.Format("{0}", name));
                }
            }
            return results;
        }

        private void FollowNamesSelectedIndexChanged(object sender, System.EventArgs e)
        {
            tweetList.Items.Clear();
            var selectedName = (sender as ListBox).SelectedItem.ToString();
            string pattern = @"^(.*)\s\(\d{0,4}\)$";

            Match match = Regex.Match(selectedName, pattern);
            if (match.Success)
            {
                selectedName = match.Groups[1].Value.Trim();
            }
            foreach(var tweet in currentTweets.Where(tweet => tweet.User.Name == selectedName))
            {
                tweetList.Items.Add(tweet.User.Name + ":" + tweet.Text);
            }
        }

        private void BtnShowAllClick(object sender, System.EventArgs e)
        {
            tweetList.Items.Clear();
            currentTweets.ForEach(tweet => tweetList.Items.Add(tweet.User.Name + ":" + tweet.Text));
        }

        private List<Status> SearchTwitter(string searchTerm)
        {
            var twitterContext = new TwitterContext(authorizedUser);

            var _search = Enumerable.SingleOrDefault((from search in twitterContext.Search
                                                      where search.Type == SearchType.Search &&
                                                      search.Query == searchTerm &&
                                                      search.Count == 200
                                                      select search));
            if (_search != null && _search.Statuses.Count > 0)
            {
                return _search.Statuses.ToList();
            }
            return new List<Status>();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(searchBtn.Text))
            {
                MessageBox.Show("Please enter a term to search for");
                return;
            }

            var results = SearchTwitter(tweetSearch.Text);
            tweetList.Items.Clear();
            results.ForEach(tweet => tweetList.Items.Add(tweet.User.Name + ":" + tweet.Text));
        }
    }
}
