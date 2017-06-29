using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestConsecutiveSequence
{
    class Program
    {
        private class Node
        {
            public string name;
            public int value;
            public Node left;
            public Node right;
            public Node(int value, string name) {
                this.value = value;
                left = null;
                right = null;
                this.name = name;
            }
        }

        static void Main(string[] args)
        {
            Node N0 = new Node(0,"N0");

            Node N1 = new Node(1, "N1");
            Node N2 = new Node(1, "N2");

            Node N3 = new Node(1, "N3");
            Node N4 = new Node(2, "N4");

            Node N5 = new Node(0, "N5");
            Node N6 = new Node(2, "N6");

            Node N7 = new Node(4, "N7");
            Node N8 = new Node(0, "N8");

            Node N9 = new Node(1, "N9");
            Node N10 = new Node(0, "N10");

            Node N11 = new Node(1, "N11");
            Node N12 = new Node(2, "N12");

            Node N13 = new Node(4, "N13");
            Node N14 = new Node(3, "N14");

            N0.left = N1;
            N0.right = N2;


            N1.left = N3;
            N1.right = N4;

            N2.left = N5;
            N2.right = N6;

            N3.left = N7;
            N3.right = N8;

            N4.left = N9;
            N4.right = N10;

            N5.left = N11;
            N5.right = N12;

            N6.left = N13;
            N6.right = N14;

            Node N15 = new Node(4, "N15");
            N14.left = N15;


            Node N16 = new Node(2, "N16");
            Node N17 = new Node(3, "N17");
            Node N18 = new Node(4, "N18");
            Node N19 = new Node(5, "N19");
            Node N20 = new Node(6, "N20");


            N11.left = N16;
            N16.left = N17;
            N17.left = N18;
            N18.right = N19;
            N19.right = N20;

            int c = 0;
            int m = 0;

            DFS(N0, c, ref m);
            
            Console.WriteLine("Finished, Max:" + m);
            Console.ReadKey();

        }

        static void DFS(Node n, int current, ref int max)
        {
            Console.WriteLine("Visiting: " + n.name);
            if(n.left != null)
            {
                Console.WriteLine("Left: " + n.value + ", " + n.left.value);

                if (n.left.value == n.value+1)
                {
                    DFS(n.left, current + 1, ref max);
                }
                else
                {
              
                    DFS(n.left, 0, ref max);
                }
                
            }
            if (n.right != null)
            {
                Console.WriteLine("Right: " + n.value + ", " + n.right.value);
                if (n.right.value == n.value + 1)
                {
                    DFS(n.right, current + 1, ref max);
                }
                else
                {
                    DFS(n.right, 0, ref max);
                }
                
            }

            if (current > max)
            {
                max = current;
                Console.WriteLine("Setting Max at: " + n.name + " to " + max);
            }
        }


    }
}
