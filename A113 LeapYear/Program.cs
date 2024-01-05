using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A113_LeapYear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what year to test?");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine((LeapYear(year)) ? $"{year} is a Leap Year" : $"{year} is not a Leap Year");
            Console.ReadKey();
        }

        static bool LeapYear(int year)
        {
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0) return true;
                    return false;
                }
                return true;
            }
            return false;
        }
    }
}
