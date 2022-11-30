using System;
namespace Powerof2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Give the Exponent");
            n = Convert.ToInt32(Console.ReadLine());
            double value = Math.Pow(2, n);
            Console.WriteLine("Result: {0}", value);
            Console.ReadLine();
        }
    }
}
