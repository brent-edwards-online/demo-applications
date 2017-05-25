using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stack_Demo
{
    public class Node
    {
        public int Data { get; }
        public Node Previous { get; set; }
        public Node(int data)
        {
            Data = data;
            Previous = null;
        }
    }
    public class Stack
    {
        Node _head = null;
        int Count = 0;

        public void Push(int data)
        {
            Node n = new Node(data);

            n.Previous = _head;
            _head = n;

            Count++;
        }

        public int Pop()
        {
            if (Count == 0)
                return -1;

            int data = _head.Data;
            Count--;

            if (Count == 0)
                _head = null;
            else
                _head = _head.Previous;

            return data;
        }

        public int Peek()
        {
            if (_head != null)
                return _head.Data;
            else
                return -1;
        }
    }
        public class Program
    {
        public static void Main(string[] args)
        {
            Stack s = new Stack();

            s.Push(102);
            Console.WriteLine(s.Peek());
            s.Push(167);
            Console.WriteLine(s.Peek());
            s.Push(718);
            Console.WriteLine(s.Peek());
            Console.WriteLine("Popping");
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());

            Console.ReadKey();
        }
    }
}
