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
            Console.WriteLine("Mode?");
            string choice = Console.ReadLine();
            Console.WriteLine("Input Please");
            string input = Console.ReadLine();
            switch (choice)
            {
                case "encrypt":
                    Console.WriteLine(Encrypt(input)); Console.ReadKey(); break;
                case "decrypt": Console.WriteLine(Decrypt(input)); Console.ReadKey(); break;
            }
            Console.ReadKey();
        }

        static string Encrypt(string input)
        {
            string Final = "";
            foreach (char c in input)
            {
                char cNew = ' ';
                int cVal = c;
                if (c == 'z' || c == 'Z') cNew = 'A';
                else if (cVal >= 65 && cVal <= 90 || cVal >= 97 && cVal <= 122)
                {
                    cVal++;
                    cNew = (char)cVal;
                }
                else cNew = c;
                if (Regex.IsMatch(cNew.ToString(), "a|e|i|o|u|A|E|I|O|U"))
                {
                    cVal = cVal-32;
                    cNew = (char)cVal;
                }
                Final = Final + cNew;
            }
            return Final;
        }

        static string Decrypt(string input)
        {
            string Final = "";
            foreach (char c in input)
            {
                char cNew = c;
                int cVal = c;
                if (Regex.IsMatch(cNew.ToString(), "a|e|i|o|u|A|E|I|O|U"))
                {
                    cVal = cVal + 32;
                    cNew = (char)cVal;
                }
                if (c == 'A') cNew = 'z';
                else if (cVal >= 65 && cVal <= 90 || cVal >= 97 && cVal <= 122)
                {
                    cVal--;
                    cNew = (char)cVal;
                }
                else cNew = c;
                Final = Final + cNew;
            }
            return Final;
        }
    }
}
