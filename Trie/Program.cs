using System;
using System.Collections.Generic;

namespace Trie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Trie Datastructure");
            string[] parts = new string[5] { "a", "mel", "lon", "el", "An" };
            Trie t = new Trie();

            foreach(string word in parts)
            {
                t.Insert(word);
            }
        }
    }

    public class Trie
    {
        private const int ALPHABET_SIZE = 122;
        private TrieNode _root = new TrieNode();

        private class TrieNode
        {
            public TrieNode[] children = new TrieNode[ALPHABET_SIZE];
            public bool isEndOfWord = false;
        }

        public void Insert(string word)
        {
            TrieNode pCrawler = _root;

            for (int level = 0; level < word.Length; level++)
            {
                int index = (int)word[level] - 65;

                if (index < 0) {
                    index = index * (-1000);
                }

                if (pCrawler.children[index] == null)
                {
                    pCrawler.children[index] = new TrieNode();
                }

                pCrawler = pCrawler.children[index];
            }

            pCrawler.isEndOfWord = true;
        }
    }
}
