using System;
using System.Collections.Generic;
using System.Text;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            // ListDemo.Run();
            Node first = new Node() {value = 5};
            Node second = new Node() {value = 1};

            first.next = second;

            Node third = new Node() {value = 3};
            second.next = third;

            PrintOutLinkedList(first);
            Console.Read(); 
        }

        private static void PrintOutLinkedList(Node node)
        {
            while(node!= null)
            {
                System.Console.WriteLine(node.value);
                node = node.next;
            }
        }
    }
}
