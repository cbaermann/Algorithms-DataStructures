using System;

namespace AlgosDataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            // JaggedArraysDemo();
            // MultiDemArrays();
            // ArraysDemo();
            // TestBasedArray();
            // IterativeFactorial(5);
            RecursiveFactorial(4);
        }

        private static int IterativeFactorial(int number)
        {
            if(number == 0)
            {
                return 1;
            }
            int factorial = 1;
            for(int i=1; i<=number; i++)
            {
                factorial *= i;
            }
            System.Console.WriteLine(factorial);
            return factorial;
        }

        private static int RecursiveFactorial(int n)
        {
            if(n == 0) 
                return 1;
            return n * RecursiveFactorial(n-1);
        }

        private static void MultiDemArrays()
        {
            int[,] r1 = new int[2,3] {{1,2,3}, {4,5,6}};
            int[,] r2 = {{1,2,3}, {4,5,6}};

            for(int i = 0; i < r2.GetLength(0); i++)
            {
                for(int j = 0; j < r2.GetLength(1); j++)
                {
                    System.Console.WriteLine($"{r2[i,j]}");
                }
                System.Console.WriteLine();
            }
        }

        private static void JaggedArraysDemo()
        {
            int[][] jaggedArray = new int[4][];
            jaggedArray[0] = new int[1];
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[2];
            jaggedArray[3] = new int[4];
            System.Console.WriteLine("Enter the numbers for a jagged array.");

            for(int i = 0; i < jaggedArray.Length; i++)
            {
                for(int j = 0; j < jaggedArray[i].Length; i++)
                {
                    string st = Console.ReadLine();
                    jaggedArray[i][j] = int.Parse(st);
                }
            }
            System.Console.WriteLine("");
            System.Console.WriteLine("Printing the Elements:");
            
            for(int i = 0; i < jaggedArray.Length; i++)
            {
                for(int j = 0; j < jaggedArray[i].Length; i++)
                {
                    System.Console.WriteLine(jaggedArray[i][j]);
                    System.Console.Write("\0");
                }
                System.Console.WriteLine("");
            }

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
