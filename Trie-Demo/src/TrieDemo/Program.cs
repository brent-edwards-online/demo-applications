using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Node
{
    public Node()
    {

    }

    public Node(char value)
    {
        _value = value;
    }

    private char _value = '*';
    Dictionary<char, Node> _children = new Dictionary<char, Node>();
    bool _isWord = false;
    int count = 0;

    public bool IsWord { get { return _isWord; } }
    public Node hasChild(char character)
    {
        if (_children.ContainsKey(character))
            return _children[character];
        else
            return null;
    }

    public void Insert(string characters)
    {
        count++;

        if (characters.Length <= 0)
            return;

        char c = characters.ToCharArray()[0];
        Node child = hasChild(c);


        if (child != null)
        {
            child.Insert(characters.Substring(1));
        }
        else
        {
            Node n = new Node(c);
            this._children.Add(c, n);
            if(characters.Length == 1)
            {
                n._isWord = true;
                return;
            }

            n.Insert(characters.Substring(1));
        }
    }
    
    public int GetCount()
    {
        return count;
    }
}

public class Trie
{
    Node root = new Node();

    public void AddWord(string word)
    {
        root.Insert(word);
    }

    public int CountWords(string subWord)
    {
        Node n = root;

        foreach(var s in subWord)
        {
            n = n.hasChild(s);
        }

        if (n == null)
            return 0;

        if(n.IsWord)
            return n.GetCount() + 1;
        else
            return n.GetCount();
    }
}



class Solution
{
    private static List<string> contactList = new List<string>();

    static void PrintLine(string s)
    {
        if (true) Console.WriteLine(s);
    }

    static void Main(String[] args)
    {
        Trie t = new Trie();

        int n = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < n; a0++)
        {
            string[] tokens_op = Console.ReadLine().Split(' ');
            string op = tokens_op[0];
            string contact = tokens_op[1];

            //PrintLine(op +  " " + contact);

            if (op == "add")
            {
                t.AddWord(contact);
            }
            else if (op == "find")
            {
                Console.WriteLine(t.CountWords(contact));
            }
        }

        Console.ReadKey();
    }
}
