using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("num1 = ");
            int Num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("num2 = ");
            int Num2 = int.Parse(Console.ReadLine());

            int ans_add = Num1 + Num2;
            int ans_mult = Num1 * Num2;
            int ans_fin = (ans_add + ans_mult) * (ans_add + ans_mult);

            Console.WriteLine("The sum of those numbers is " + ans_add);
            Console.WriteLine("the product of those numbers is " + ans_mult);
            Console.WriteLine("the previous answers added together and squared" + ans_fin);

            Console.ReadKey();


        }
    }
}
