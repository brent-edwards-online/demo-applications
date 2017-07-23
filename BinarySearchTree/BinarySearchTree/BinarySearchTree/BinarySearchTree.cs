using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinarySearchTree : IBinarySearchTree
    {
        Node _head;

        public void Insert(Node node)
        {
            if(_head == null)
            {
                _head = node;
            }
            else
            {
                Node curr = _head;
                while(curr != null)
                {
                    if(node.Value <= curr.Value)
                    {
                        if(curr.Left == null)
                        {
                            curr.Left = node;
                            curr = null;
                        }
                        else
                        {
                            curr = curr.Left;
                        }
                    }
                    else
                    {
                        if (curr.Right == null)
                        {
                            curr.Right = node;
                            curr = null;
                        }
                        else
                        {
                            curr = curr.Right;
                        }
                    }
                }
            }
        }

        public Node Search(int value)
        {
            Node curr = _head;

            while(curr != null)
            {
                if(curr.Value == value)
                {
                    return curr;
                }
                else
                {
                    if(value < curr.Value)
                    {
                        curr = curr.Left;
                    }
                    else
                    {
                        curr = curr.Right;
                    }
                }
            }


            return null;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
