using System;

namespace Exe4_149
{
    class Node
    {
        public int info;
        public Node next;
        public Node (int i, Node n)
        {
            info = i;
            next = n;
        }
    }
    class Stacks
    {
        Node top;
        public Stacks()
        {
            top = null;
        }
        bool empty()
        {
            if (top == null)
                return (true);
            else
                return (false);
        }
        public void pop()
        {
            Console.WriteLine("\nThe popped element is: " + top.info);
            top= top.next;
        }
        public void push(int element)
        {
            Node fresh;
            fresh = new Node(element, null);

            fresh.next = top;
            top = fresh;
            Console.WriteLine("\n" + element + "pushed.");
        }
        public void display()
        {
            Node tmp;
            if (empty())
                Console.WriteLine("\nStack Empty");
            else
            {
                for (tmp = top; tmp != null; tmp = tmp.next)
                {
                    Console.WriteLine(tmp.info);
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Stacks s = new Stacks();
            while(true)
            {
                Console.WriteLine();
                Console.WriteLine("\n***Stack Menu***\n");
                Console.WriteLine("1. Pop");
                Console.WriteLine("2. Push");
                Console.WriteLine("3. Display");
                Console.WriteLine("4. Exit");
                Console.Write("\nEnter your choice: ");
                string sInput = Console.ReadLine();
                char ch = Convert.ToChar(sInput == "" ? "0" : sInput);
                switch(ch)
                { }
            }
        }
    }
}