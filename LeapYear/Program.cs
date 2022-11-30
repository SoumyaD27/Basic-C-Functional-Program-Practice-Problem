using System;
namespace LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;
            Console.WriteLine("Enter the year: ");
            year = Convert.ToInt32(Console.ReadLine());
            if(year % 4 == 0)
            {
                Console.WriteLine("This year is leap year");
            }
            else
            {
                Console.WriteLine("This year is not leap year");
            }
            Console.ReadLine();
        }
    }
}