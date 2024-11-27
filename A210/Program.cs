using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A210
{
    internal class Program
    {
        static char[] SingleOs = new char[] { 'a', 'b', 'd', 'e', 'g', 'o', 'p', 'q', '0', '6', '9', 'D', 'O', 'P', 'Q', 'R', '@'};
        static char[] DoubleOs = new char[] { '%', '&', 'B', '8'};
        static void Main(string[] args)
        {
            Console.WriteLine(GrawpOs("8% of 60 is 4.8"));
            Console.ReadKey();
        }

        static int GrawpOs(string str) => str.Aggregate(0, (tot, cur) => SingleOs.Contains(cur) ? tot+=1 : DoubleOs.Contains(cur) ? tot+=2 : tot);
    }
}
