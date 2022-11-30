//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
namespace TypeCasting
{
    internal class Program
    {
        static void Main(string[] agrs)
        {
            int a = 20;
            float b = a;
            Console.WriteLine(b);                      //Implicit type casting
            float c = 20.34f;
            int d = (int)c;                            //Explicit type casting
            Console.WriteLine(d);

            Console.WriteLine("Enter 1st number: ");
            int v = int.Parse(Console.ReadLine());     //Type Conversion using Parse()
            Console.WriteLine(v);

            Console.WriteLine("Enter number:");
            double f = Convert.ToDouble(Console.ReadLine());  //Type Conversion using Convert Class
            Console.WriteLine(f);

            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();          //Read the string values
            Console.WriteLine(name);
        }
    }
}