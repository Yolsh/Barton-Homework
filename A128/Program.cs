using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A128
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DeCipher(Console.ReadLine()));
            Console.ReadKey();
        }

        static string DeCipher(string n) => n.Length >= 2 ? 
            int.Parse(n.Substring(0, 2)) <= 97 && int.Parse(n.Substring(0, 2)) != 32 ? 
            n.Length >= 3 ?
            int.Parse(n.Substring(0, 3)) >= 122 ? "" : 
            ((char)int.Parse(n.Substring(0, 3))).ToString() + DeCipher(new string(n.Skip(3).ToArray())) : "" : 
            ((char)int.Parse(n.Substring(0, 2))).ToString() + DeCipher(new string(n.Skip(2).ToArray())) : "";
    }
}
