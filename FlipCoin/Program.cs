using System;
namespace FlipCoin
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,n;
            Console.WriteLine("Enter Number of times to flip the coin: ");
            n = int.Parse(Console.ReadLine());
            int CountHead = 0;
            int CountTail = 0;

            for(i=1;i<=n;i++)
            {
                Random rnd = new Random();
                int num = rnd.Next(2);

                if(num==1)
                {
                    Console.WriteLine("Heads");
                    CountHead++;
                }
                else
                {
                    Console.WriteLine("Tails");
                    CountTail++;
                }
            }
            Console.WriteLine("{0} is number of heads",CountHead);
            Console.WriteLine("{0} is number of tails",CountTail);

            double Heads = CountHead / (double)n * 100;
            double Tails = CountTail / (double)n * 100;

            Console.WriteLine("{0} is % of heads",Heads);
            Console.WriteLine("{0} is % of tails",Tails);

        }
    }
}