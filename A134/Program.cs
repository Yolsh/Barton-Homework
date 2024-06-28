using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A134
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Disarium(int.Parse(Console.ReadLine())));
            Console.ReadKey();
        }

        static bool Disarium(int n) => n.ToString().Select((x, a) => Math.Pow(int.Parse(x.ToString()), a + 1)).Aggregate((a, b) => a + b).Equals(n);

        static int Longest(string s) => s.Split('0').Select(x => x.Replace("0", "")).Aggregate("", (max, cur) => max.Length > cur.Length ? max : cur).Length;
    }
}
