using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A126
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iterate: Num Pls?");
            Console.WriteLine(DoubleFactIterate(int.Parse(Console.ReadLine())));
            Console.WriteLine("Recursive: Num Pls?");
            Console.WriteLine(DoubleFactIterate(int.Parse(Console.ReadLine())));
            Console.ReadKey();
        }

        static int DoubleFactRec(int n) => n <= 0 ? 1 : n * DoubleFactRec(n - 2);

        static int DoubleFactIterate(int num)
        {
            int OutNum = 1;
            while (num > 0)
            {
                OutNum *= num;
                num = num - 2;
            }
            return OutNum;
        }
    }
}
