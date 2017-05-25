using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Queue_Demo
{
    public class Node
    {
        public int Data { get;}
        public Node Next { get; set; }
        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }
    public class Queue
    {
        Node _head = null;
        Node _tail = null;

        public void Enqueue(int data)
        {
            Node n = new Queue_Demo.Node(data);
            Enqueue(n);
        }
        public void Enqueue(Node n)
        {
            if(_head == null)
            {
                _head = n;
                _tail = n;
            }
            else
            {
                _tail.Next = n;
                _tail = n;
            }
        }

        public int Dequeue()
        {
            if (_head == null)
                return -1;

            int data = _head.Data;

            if (_head.Next != null)
                _head = _head.Next;
            else
            {
                _head = null;
                _tail = null;
            }

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
            Queue q = new Queue();

            q.Enqueue(10);
            q.Enqueue(11);
            q.Enqueue(12);
            q.Enqueue(13);

            Console.WriteLine("Peek " + q.Peek());
            Console.WriteLine(q.Dequeue());
            Console.WriteLine("Peek " + q.Peek());
            Console.WriteLine(q.Dequeue());
            Console.WriteLine("Peek " + q.Peek());
            Console.WriteLine(q.Dequeue());
            q.Enqueue(20);
            q.Enqueue(30);
            q.Enqueue(40);
            q.Enqueue(50);
            Console.WriteLine("Peek " + q.Peek());
            Console.WriteLine(q.Dequeue());
            Console.WriteLine("Peek " + q.Peek());
            Console.WriteLine(q.Dequeue());
            Console.WriteLine("Peek " + q.Peek());
            Console.WriteLine(q.Dequeue());
            Console.WriteLine("Peek " + q.Peek());
            Console.WriteLine(q.Dequeue());
            Console.WriteLine("Peek " + q.Peek());
            Console.WriteLine(q.Dequeue());
            Console.WriteLine("Peek " + q.Peek());
            Console.WriteLine(q.Dequeue());
            Console.ReadKey();
        }
    }
}
