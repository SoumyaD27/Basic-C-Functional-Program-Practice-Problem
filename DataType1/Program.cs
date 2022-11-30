//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
namespace DataTypes
{
    internal class Program
    {
        static void Main(string[] agrs)
        {   //DataTypes in C#
            //int and byte

            int a = 10;
            int b = -10;
            byte c = 255;
            Console.WriteLine(c);        //different ways to print 
            Console.WriteLine("value of b is" + b);
            Console.WriteLine("{0} {1} {2} are the values of a, b and c", a, b, c);

            //boolean

            bool d = a > b;             //bool gives result as True or False
            Console.WriteLine(d);

            //float, double and decimal

            float e = 2.564f;           //float takes only 8 digits with suffix f
            double f = 456.876d;        //double takes 15-16 digits with or without suffix d
            decimal g = 1234.5678m;     //decimal takes 28-29 digits after decimal point with suffix m
            Console.WriteLine("{0} {1} {2}", e, f, g);

            //String, Char

            string s1 = "Soumya";       //string should always be in ""
            char c1 = 'D';              //char should always be in ''
            Console.WriteLine("{0} {1}", s1, c1);


        }
    }
}
