using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace A201
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(CalcWorld("00X0001000X00X"));
            Console.WriteLine("\n");
            Console.WriteLine(CalcWorld("0000001000100X"));
            Console.ReadKey();
        }

        static string CalcWorld(string s) => $"Start map: {s}\nFinal map: {s.Select((cur, index) => cur == '0' && (s.Substring(index, s.Substring(index, s.Length - index).ToList().IndexOf('X')).Contains('1') || s.Substring(s.Substring(0, index).ToList().LastIndexOf('X') != -1 ? s.Substring(0, index).ToList().LastIndexOf('X') : 0,index - s.Substring(0, index).ToList().LastIndexOf('X')).Contains('1')) ? '1' : cur).Aggregate("", (tot, cur) => tot += cur)}\nTotal Population: {s.Replace("X", "").Length}\nNumber Infected: {s.Select((cur, index) => cur == '0' && (s.Substring(index, s.Substring(index, s.Length - index).ToList().IndexOf('X')).Contains('1') || s.Substring(s.Substring(0, index).ToList().LastIndexOf('X') != -1 ? s.Substring(0, index).ToList().LastIndexOf('X') : 0, index - s.Substring(0, index).ToList().LastIndexOf('X')).Contains('1')) ? '1' : cur).Aggregate("", (tot, cur) => tot += cur).Replace("X", "").Replace("0", "").Length}\nTotal Percentage of World Infected: {(int)(s.Select((cur, index) => cur == '0' && (s.Substring(index, s.Substring(index, s.Length - index).ToList().IndexOf('X')).Contains('1') || s.Substring(s.Substring(0, index).ToList().LastIndexOf('X') != -1 ? s.Substring(0, index).ToList().LastIndexOf('X') : 0, index - s.Substring(0, index).ToList().LastIndexOf('X')).Contains('1')) ? '1' : cur).Aggregate("", (tot, cur) => tot += cur).Replace("X", "").Replace("0", "").Length / (double)s.Replace("X", "").Length * 100)}%";
    }
}
