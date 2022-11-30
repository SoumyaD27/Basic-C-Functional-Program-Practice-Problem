using System;
namespace QuotientReminder
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter b: ");
            b = int.Parse(Console.ReadLine());
            int quot = a / b;
            int remi = a % b;
            Console.WriteLine("{0} is quotient,{1} is reminder",quot, remi);


        }
    }
}
