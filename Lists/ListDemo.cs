using System;
using System.Collections.Generic;
using System.Text;

namespace Lists
{
    public class Customer
    {
        public string Name{get;set;}
        public DateTime Birthdate{get;set;}
    }
    public class ListDemo
    {
        public static void Run()
        {
            List<int> list = new List<int>();
            LogCountAndCapacity(list);

            for(int i=0; i<16;i++)
            {
                list.Add(i);
                LogCountAndCapacity(list);
            }
            for(int i = 10; i > 0; i--)
            {
                list.RemoveAt(i -1);
                LogCountAndCapacity(list);
            }
            //have effect if less than 90% of capacity is used 
            list.TrimExcess();
            LogCountAndCapacity(list);

            list.Add(1);
            LogCountAndCapacity(list);


            Console.Read();
        }

        public static void ApiMembers()
        {
            var list  = new List<int>() {1, 0, 5, 3, 4};
            list.Sort();

            int indexBinSearch = list.BinarySearch(3);

            list.Reverse();            

            var listCustomers = new List<Customer>
            {
                new Customer {Birthdate = new DateTime(1988, 08, 12), Name = "Elias"},
                new Customer {Birthdate = new DateTime(1990, 06, 09), Name = "Mariana"},
                new Customer {Birthdate = new DateTime(2015, 06, 09), Name = "Ann"},
            };
            listCustomers.Sort((left,right)=>
            {
                if(left.Birthdate > right.Birthdate)
                    return 1;
                if(right.Birthdate > left.Birthdate)
                    return -1;
                return 0;
            });

        }
        private static void LogCountAndCapacity(List<int> list)
        {
            System.Console.WriteLine($"Count={list.Count}. Capacity={list.Capacity}");
        }
    }
}