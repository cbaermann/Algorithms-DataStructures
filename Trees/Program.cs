using System;
using System.Collections.Generic;

//root node, one root node in tree. Has no Parents
//elements w/out children are "leaf nodes".
//link between nodes is an edge. 
//tree can not have cyclic paths.
//Log(n) for insertion, deletion, and retrieval


namespace Trees
{
    class Program
    {
        static void Main(string[] args)
        {
            var bstTest = new Bst<int>();
            bstTest.Insert(37);
            bstTest.Insert(24);
            bstTest.Insert(17);
            bstTest.Insert(28);
            bstTest.Insert(31);
            bstTest.Insert(29);
            bstTest.Insert(15);
            bstTest.Insert(12);
            bstTest.Insert(20);

            foreach(var i in bstTest.TraverseInOrder())
            {
                Console.Write($"{i} ");
            }
            System.Console.WriteLine();
            System.Console.WriteLine(bstTest.Min());
            System.Console.WriteLine(bstTest.Max());
            System.Console.WriteLine(bstTest.Get(20).Value);
            Console.Read();
        }
    }
}
