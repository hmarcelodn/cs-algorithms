using System.Collections;
using System.Collections.Generic;

namespace Trie2
{
    public class Trie
    {
        private TrieNode root = new TrieNode();

        public void Insert(string word)
        {
            TrieNode current = root;

            foreach (char c in word)
            {
                if (!current.Children.ContainsKey(c))
                {
                    current.Children.Add(c, new TrieNode());
                }

                current = (TrieNode)current.Children[c];
                current.Content = c;
                current.Size++;
            }

            current.IsWord = true;
        }

        public bool Search(string word)
        {
            TrieNode current = root;

            foreach (char c in word)
            {
                if (!current.Children.ContainsKey(c))
                {
                    return false;
                }

                current = (TrieNode)current.Children[c];
                current.Content = c;
            }

            return current.IsWord;
        }

        public int Matches2(string prefix)
        {
            TrieNode current = root;
            IList<string> prefixedWords = new List<string>();

            foreach (char c in prefix)
            {
                if (!current.Children.ContainsKey(c))
                {
                    return 0;
                }

                current = (TrieNode)current.Children[c];
                current.Content = c;
            }

            return current.Size;
        }

        public IList<string> Matches(string prefix)
        {
            TrieNode current = root;
            IList<string> prefixedWords = new List<string>();

            foreach (char c in prefix)
            {
                if (!current.Children.ContainsKey(c))
                {
                    return new List<string>();
                }

                current = (TrieNode)current.Children[c];
                current.Content = c;
            }

            foreach (TrieNode n in current.Children.Values)
            {
                RecursiveMatching(n, prefix, prefixedWords);
            }

            return prefixedWords;
        }

        private void RecursiveMatching(TrieNode node, string word, IList<string> prefixedWords)
        {
            word = word + node.Content;

            // Base Case
            if (node.IsWord) {
                prefixedWords.Add(word);
            }

            if (node.IsWord && node.Children.Count == 0)
            {
                return;
            }

            // Recursion
            foreach (TrieNode n in node.Children.Values)
            {
                RecursiveMatching(n, word, prefixedWords);
            }

        }

    }

    class TrieNode
    {
        public Hashtable Children = new Hashtable();
        public char Content;
        public bool IsWord = false;
        public int Size = 0;
    }
}
