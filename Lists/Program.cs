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
            Console.Read(); 
        }

        private static void PrintOutLinkedList(Node<T> node)
        {
            while(node!= null)
            {
                System.Console.WriteLine(node.value);
                node = node.next;
            }
        }
    }
}
