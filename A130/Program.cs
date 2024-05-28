using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A130
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Part2();
        }

        static void Part2()
        {
            Console.WriteLine("Enter integer (0-99): ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Calculate additive or multiplicative persistence (a or m)? ");
            string persistence = Console.ReadLine();

            int count = 0;
            while ((num/10)%10 != 0)
            {
                if (persistence == "a") num = int.Parse(num.ToString()[1].ToString()) + int.Parse(num.ToString()[0].ToString());
                if (persistence == "m") num = int.Parse(num.ToString()[1].ToString()) * int.Parse(num.ToString()[0].ToString());
                count++;
            }

            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
