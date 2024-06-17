using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A132
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Uncensor("xyz", ""));
            Console.ReadKey();
        }

        static string Uncensor(string plaintext, string missingLetters)
        {
            string fullText = "";
            int i = 0;
            foreach (char c in plaintext)
            {
                if (c == '*')
                {
                    fullText += missingLetters[i];
                    i++;
                    continue;
                }
                fullText += c;
            }
            return fullText;
        }
    }
}
