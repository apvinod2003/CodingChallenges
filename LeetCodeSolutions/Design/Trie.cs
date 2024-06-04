using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Design
{
    public class TrieNode
    {
        public Dictionary<char,  TrieNode> Children;
        public bool isEnd;

        public TrieNode()
        {
            Children = new Dictionary<char, TrieNode>();
            isEnd = false;
        }
    }
    public class Trie
    {
        private TrieNode root;
        public Trie()
        {
            root = new TrieNode();
        }

        public void Insert(string word)
        {
            TrieNode iter = root;
            foreach (char ch in word)
            {
                if (!iter.Children.ContainsKey(ch))
                    iter.Children.Add(ch, new TrieNode());
                iter = iter.Children[ch];
            }

            iter.isEnd = true;  
        }

        public bool Search(string word)
        {
            TrieNode iter = root;
            foreach (char ch in word)
            {
                if (!iter.Children.ContainsKey(ch))
                    return false;
                iter = iter.Children[ch];
            }

            return iter.isEnd == true;
        }

        public bool StartsWith(string prefix)
        {
            TrieNode iter = root;
            foreach (char ch in prefix)
            {
                if (!iter.Children.ContainsKey(ch))
                    return false;
                iter = iter.Children[ch];
            }

            return true;
        }
    }
}
