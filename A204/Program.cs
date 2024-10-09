using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml.Schema;

namespace A204
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "nouveau";
            Console.WriteLine($"{str} -> {VowelMoveOne(str)}");
            Console.ReadKey();
        }

        static string VowelMove(string tomove)
        {
            string new_str = "";
            string vowels = "";
            for (int i = 0; i < tomove.Length; i++)
            {
                if (Regex.IsMatch(tomove[i].ToString(), "a|e|i|o|u|A|E|I|O|U"))
                {
                    vowels += tomove[i];
                }
                else
                {
                    new_str += tomove[i];
                }
            }
            return new_str + vowels;
        }

        static string VowelMoveOne(string tomove) => tomove.Split('a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U').Append(tomove.Aggregate("", (tot, cur) => Regex.IsMatch(cur.ToString(), "a|e|i|o|u|A|E|I|O|U") ? tot += cur : tot)).Aggregate("", (tot, cur) => tot += cur);
    }
}
