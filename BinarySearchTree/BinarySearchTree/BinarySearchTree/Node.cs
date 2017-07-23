using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class Node : INode
    {
        public Node(int v)
        {
            Value = v;
        }
        public int Value { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
    }
}
