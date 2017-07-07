using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoComplete_Trie.Trie
{
    public sealed class TrieNode
    {
        public Dictionary<string, TrieNode> children;
        public bool isWord;
        public string word;

        public TrieNode()
        {
            children = new Dictionary<string, TrieNode>();
        }
    }

    public sealed class Trie : ITrie
    {
        private TrieNode _head = new TrieNode();

        public List<string> AutoComplete(string prefix)
        {
            bool found = false;
            TrieNode current = _head;
            foreach( var character in prefix)
            {
                var key = character.ToString();

                if (current.children.ContainsKey(key))
                {
                    current = current.children[key];
                    found = true;
                }
                else
                {
                    found = false;
                }
            }

            if (found)
                return DFS(current);
            else
                return new List<string>();
        }

        private List<string> DFS(TrieNode node)
        {
            List<string> result = new List<string>();
            if(node.isWord)
            {
                result.Add(node.word);
            }

            foreach( var key in node.children.Keys)
            {
                var r = DFS(node.children[key]);
                result.AddRange(r);
            }

            return result;
        }



        public void Create(string[] dictionary)
        {
            foreach( var word in dictionary)
            {
                TrieNode current = _head;

                foreach ( var character in word)
                {
                    var key = character.ToString();

                    if(current.children.ContainsKey(key))
                    {
                        current = current.children[key];
                    }
                    else
                    {
                        TrieNode newNode = new TrieNode();
                        current.children.Add(key, newNode);
                        current = newNode;
                    }
                }

                current.isWord = true;
                current.word = word;
            }
        }
    }
}
