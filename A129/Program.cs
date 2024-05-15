using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace A129
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(unique("L3_37"));
            //Console.WriteLine(pattern(11));
            Console.ReadKey();
        }

        static string pattern(int n)
        {
            string ans = "";
            for (int i = 0; i < n + 1; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    ans += i;
                }
                if (i != 0) ans += "\n";
            }
            return ans;
        }

        static bool unique(string s) => s.Distinct().Count() == s.Length;
    }
}
