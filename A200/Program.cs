using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace A200
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> strings = new List<string>
            {
                "ABodE",
                "abc",
                "xyz",
                "xBkd"
            };
            Console.WriteLine(MatchChecker(strings));
            Console.ReadKey();
        }

        static string MatchChecker(List<string> s) => s.Select(x => x.ToLower()).Select(x => Enumerable.Range(0, 26).Aggregate(0, (tot, cur) => cur > x.Length - 1 ? tot : cur + 97 == x[cur] ? tot+1 : tot).ToString()).Aggregate("", (tot, next) => tot += $"{next}, ");
    }
}
