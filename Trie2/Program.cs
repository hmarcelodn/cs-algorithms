using System;

namespace Trie2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Radix Tree \n");
            Trie t = new Trie();
            string phrase = "hack hackerrank";
            string[] wordsFromPhrase = phrase.Split(" ");

            foreach (string s in wordsFromPhrase)
            {
                Console.WriteLine(string.Format("Inserting {0} ...", s));
                t.Insert(s.ToLower());
            }

            Console.WriteLine("Word to search: ");
            string prefix = Console.ReadLine();

            Console.WriteLine(string.Format("{0} : {1}", prefix, t.Search(prefix)));
            var words = t.Matches2(prefix);

            Console.WriteLine("Count:" + words);

            //Console.WriteLine("\nSimilares");
            //foreach (string s in words)
            //{
            //    Console.WriteLine(s.Trim());
            //}

            Console.ReadKey();
        }
    }
}
