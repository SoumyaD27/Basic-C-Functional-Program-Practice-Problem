using System;
namespace HarmonicNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            Console.WriteLine("Number of terms:");
            n = Convert.ToInt32(Console.ReadLine());
            for(i=1;i<=n;i++)
            {
                Console.Write("1/{0}+", i);
            }
        }
    }
}