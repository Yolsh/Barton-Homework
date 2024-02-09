using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A117
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary?");
            string Bin = Console.ReadLine();
            Console.WriteLine("Number of bits to flip?");
            binaryFlip(Bin, int.Parse(Console.ReadLine()));
            Console.ReadKey();
        }

        static void binaryFlip(string Bin, int Pos)
        {
            string Final = "";
            string ToFlip = Bin.Substring(Bin.Length - Pos);
            foreach (char c in ToFlip)
            {
                if (c == '0') Final = Final + "1";
                else if (c == '1') Final = Final + "0";
                else Final = Final + c;
            }
            Console.WriteLine(Bin.Substring(0, Bin.Length - Pos) + Final);
        } 
    }
}
