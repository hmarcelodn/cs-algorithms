using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;

namespace WebCrawler
{
    public class Crawler
    {
        protected Queue<string> sitesQueue = new Queue<string>();
        protected IList<string> discoveredWebSites = new List<string>();

        public void DiscoverWebSites(string root)
        {
            this.sitesQueue.Enqueue(root);

            while (this.sitesQueue.Count > 0) {
                var site = this.sitesQueue.Dequeue();
                var raw = rawHtml(site);
                Console.WriteLine(string.Format("Discovered: {0}", site));

                var pattern = new Regex("http?://(\\w+\\.)(\\w+)");
                var matcher = pattern.Match(raw);

                while (!string.IsNullOrEmpty(matcher.Value)) {
                    if (!this.discoveredWebSites.Contains(matcher.Value)) {
                        var currentUrl = matcher.Groups;
                        this.sitesQueue.Enqueue(matcher.Value);
                        this.discoveredWebSites.Add(matcher.Value);
                    }

                    matcher = matcher.NextMatch();
                }
            }
        }

        private string rawHtml(string site)
        {
            try
            {
                var myRequest = (HttpWebRequest)WebRequest.Create(site);
                myRequest.Method = "GET";
                var myResponse = myRequest.GetResponse();
                var sr = new StreamReader(myResponse.GetResponseStream(), System.Text.Encoding.UTF8);
                var result = sr.ReadToEnd();
                sr.Close();
                myResponse.Close();

                return result;
            }
            catch
            {
                return string.Empty;
            }
        }
    }
}
