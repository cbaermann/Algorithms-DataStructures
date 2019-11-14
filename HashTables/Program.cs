using System;
using System.Collections.Generic;

namespace HashTables
{
    class Program
    {
        static void Main(string[] args)
        {
            var number1 = new PhoneNumber(){AreaCode = "141804", Exchange="27", Number = "90319334"};
            var number2 = new PhoneNumber(){AreaCode = "141804", Exchange="27", Number = "90319334"};
            var number3 = new PhoneNumber(){AreaCode = "141804", Exchange="27", Number = "90319334"};

            System.Console.WriteLine(number1.GetHashCode());
            System.Console.WriteLine(number2.GetHashCode());
            System.Console.WriteLine(number1==number2);
            System.Console.WriteLine(number1.Equals(number2));

            var customers = new Dictionary<PhoneNumber, Person>();
            customers.Add(number1, new Person());
            customers.Add(number2, new Person());

            System.Console.WriteLine("After adding phone numbers.");

            var c = customers[number3];
            Console.Read();

        }
    }
}
