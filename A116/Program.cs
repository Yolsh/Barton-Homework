using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace A116
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("String?");
            Console.WriteLine((Isogram(Console.ReadLine().ToLower())) ? "That string is an Isogram" : "That string is not an Isogram");
            Console.ReadKey();
        }

        static bool Isogram(string Lowers)
        {
            char[] chars = Lowers.ToCharArray();
            int MatchNum = Regex.Matches(Lowers, chars[0].ToString()).Count;
            for (int i = 1; i < chars.Length; i++)
            {
                if (MatchNum != (Regex.Matches(Lowers, chars[i].ToString()).Count)) return false;
            }
            return true;
        }
    }
}
