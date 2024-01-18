using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace A115
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input Please");
            string input = Console.ReadLine();
            Console.WriteLine(Encrypt(input));
            Console.ReadKey();
        }

        static string Encrypt(string input)
        {
            string Final = "";
            foreach (char c in input)
            {
                char cNew = ' ';
                if (c == 'z' || c == 'Z')
                {
                    cNew = 'A';
                }
                else
                {
                    int cVal = c;
                    cVal++;
                    cNew = (char)cVal;
                }
                if (Regex.IsMatch(cNew.ToString(), "a|e|i|o|u|A|E|I|O|U"))
                {
                    int cVal = c;
                    cVal = cVal-32;
                    cNew = (char)cVal;
                }
                Final = Final + cNew;
            }
            return Final;
        }
    }
}
