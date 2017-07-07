using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NthToLastItem
{
    class Program
    {
        public class Node
        {
            static int number = 0;
            public Node next;
            private int _number;

            public Node() {

                this._number = number;
                number++;
                next = null;
            }

            public override string ToString()
            {
                return "Node: " + this._number;
            }
        }

        static Node SetUp(int count)
        {
            Node head = null;
            Node current = null;

            for (var i = 0; i < count; i++)
            {
                Node newnode = new Node();
                if (head == null)
                {
                    head = newnode;
                }
                else
                {
                    current.next = newnode;
                }
                current = newnode;
            }

            return head;
        }

        static Node KthToLast(int k, Node head)
        {
            Node lead = head;
            Node follow = head;

            for(var idx = 0; idx < k; idx++)
            {
                if(lead.next == null)
                {
                    return null;
                }
                lead = lead.next;
            }

            while(lead != null)
            {
                lead = lead.next;
                follow = follow.next;
            }

            return follow;
        }

        static void Main(string[] args)
        {
            const int NODE_COUNT = 25;

            Node head = SetUp(NODE_COUNT);
            Node current = null;
            
            current = head;
            while(current != null)
            {
                Console.WriteLine(current.ToString());
                current = current.next;
            }

            Node k = KthToLast(10, head);

            if(k == null)
            {
                Console.WriteLine("No node found");
            }
            else
            {
                Console.WriteLine("Node Found, " + k.ToString());
            }
            Console.ReadKey();
        }
    }
}
