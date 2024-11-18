using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A208
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Feast("ron weasley", "raspberry trifle"));
            Console.ReadKey();
        }

        static bool Feast(string student, string dish) => student.ToLower()[0] == dish.ToLower()[0] && student.ToLower()[student.Length-1] == dish.ToLower()[dish.Length-1];
    }
}
