using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A127
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(OddsEvens(true, int.Parse(Console.ReadLine())));
            Console.ReadKey();

        }
        
        static string RevString(string n) => n.Length == 1 ? n : RevString(n.Substring(1)) + n[0];
        static char FirstCap(string n) => n[0] >= 65 && n[0] <= 90 ? n[0] : FirstCap(n.Substring(1));
        static string OddsEvens(bool odds, int n, string hold = "") => odds ? n == 1 ? "1" : n % 2 == 1 ?
            OddsEvens(odds, n-2, hold) + n : OddsEvens(odds, n-1, hold) : n == 2 ? "2" : n % 2 == 0 ?
            OddsEvens(odds, n-2, hold) + n : OddsEvens(odds, n-1, hold);
    }
}
