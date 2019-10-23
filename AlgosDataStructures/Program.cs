using System;

namespace AlgosDataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            // ArraysDemo();
            TestBasedArray();
            Console.Read();
        }
        private static void ArraysDemo()
        {
            int[] a1 = new int[10];
            int[] a3 = new int[5] {1,3,-2,5,10};
            int[] a4 = {1,2,3,4,5};
            
            for(int i = 0; i <a3.Length-1; i++)
            {
                Console.WriteLine($"{a3[i] }");
            }

            foreach(var el in a4)
            {
                Console.WriteLine($"{el} ");
            }

            Array myarray = new int[5];
            Array myArray2 = Array.CreateInstance(typeof(int), 5);

            Console.Read();
        }

        private static void TestBasedArray()
        {
            Array myArray = Array.CreateInstance(typeof(int), new[] {4}, new[] {1});

            myArray.SetValue(2019, 1);
            myArray.SetValue(2020, 2);
            myArray.SetValue(2021, 3);
            myArray.SetValue(2022, 4);

            Console.WriteLine($"Starting index:{myArray.GetLowerBound(0)}");
            Console.WriteLine($"Ending index:{myArray.GetUpperBound(0)}");

            for(int i=1; i<5; i++)
            {
                System.Console.WriteLine($"{myArray.GetValue(i)} at index {i}");
            }
        }
    }
}
