using System;
namespace EvenOrOddNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number: ");
            int n = int.Parse(Console.ReadLine());
            if(n%2== 0)
            {
                Console.WriteLine("It's a Even Number.");
            }
            else
            {
                Console.WriteLine("It's a Odd Number.");
            }
        }
    }
}
