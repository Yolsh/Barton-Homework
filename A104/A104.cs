using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace A104
{
    internal class A104
    {

        static void Q1()
        {
            Random rnd = new Random();

            Console.WriteLine("How many sides on Dice?");
            int sides = int.Parse(Console.ReadLine());
            Console.WriteLine("How many rolls would you like?");
            int rolls = int.Parse(Console.ReadLine());

            Console.WriteLine("Output:");

            for (int i = 0; i < rolls; i++)
            {
                Console.WriteLine(rnd.Next(sides));
            }
        }

        static void Q2()
        {
            int total = 0;
            string choice;

            Console.WriteLine("Number?");
            int num = int.Parse(Console.ReadLine());

            if (ch oice == "s")
            {
                for (int i = 0; i <= num; i++)
                {
                    total += i;
                }
                Console.WriteLine(total);
            }
            else if (choice == "f")
            {
                total = 1;
                for (int i = 1; i <= num; i++)
                {
                    total *= i;
                }
                Console.WriteLine(total);
            }
            else
            {
                Console.WriteLine("incorrect input");
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Which Question?");
            int Prog_run = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (Prog_run)
            {
                case 1: Q1(); break;
                case 2: Q2(); break;
            }

            Console.ReadKey();
        }
    }
}
