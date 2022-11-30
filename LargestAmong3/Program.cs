using System;
namespace LargestAmong3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.WriteLine("Enter first number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number: ");
            num3 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("{0} is the Largest", num1);
                }
                else
                {
                    Console.WriteLine("{0} is the Largest", num3);
                }
            }
            else if (num2 > num3)
                Console.WriteLine("{0} is the Largest", num2);
            else
                Console.WriteLine("{0} is the Largest", num3);
        }
    }
}
