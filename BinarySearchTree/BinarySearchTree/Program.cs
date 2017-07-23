using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            IBinarySearchTree tree = new BinarySearchTree();
            Node[] nodes = new[]
            {
                new Node(5),
                new Node(7),
                new Node(3),
                new Node(1),
                new Node(2),
                new Node(9),
                new Node(5),
                new Node(4),
                new Node(8),
                new Node(1),
                new Node(3),
            };

            foreach(var node in nodes)
            {
                tree.Insert(node);
            }

            Node n = tree.Search(9);
            n = tree.Search(100);


            Console.ReadKey();
        }
    }
}
