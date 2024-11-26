using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace A209
{
    internal class Program
    {
        static string[] dict = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        static void Main(string[] args)
        {
            descend(987);
            Console.ReadKey();
        }

        static void descend(int num1)
        {
            string numTS = "";
            foreach (char digit in num1.ToString()) numTS += dict[int.Parse(digit.ToString())];
            Console.Write(numTS + ", ");
            if (numTS.Length == num1) return;
            descend(numTS.Length);
        }
    }
}
