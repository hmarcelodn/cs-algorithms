using System;

namespace WebCrawler
{
    class Program
    {
        static void Main(string[] args)
        {
            var crawler = new Crawler();
            crawler.DiscoverWebSites("https://www.codeproject.com");

            Console.WriteLine("Press to finish...");
            Console.ReadKey();
        }
    }
}
