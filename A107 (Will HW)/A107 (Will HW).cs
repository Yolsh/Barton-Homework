using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace A107__Will_HW_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string x = "true";
            int total = 0;
            string name;
            Console.WriteLine("Enter done to end program");
            while (x == "true")
            {
                Console.WriteLine("Enter name");
                name = Console.ReadLine();
                Thread.Sleep(1000);
                if (name == "done")
                {
                    break;
                }
                else
                {
                    total = total + 1;
                }
            }
            Console.WriteLine("The number of people in the class is " + total);
            Console.ReadKey();
        }
    }
}
