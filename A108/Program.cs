using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace A108
{
    internal class Program
    {
        static void Q1()
        {
            int[] array = { 34, 15, 88, 2 };
            int low = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < low)
                {
                    low = array[i];
                }
            }
            Console.WriteLine(low);
            Console.ReadKey();
        }

        static void Q2()
        {
            int[] fibonacci = new int[31];
            fibonacci[0] = 0;
            fibonacci[1] = 1;

            for (int i = 2; i < 31; i++)
            {
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
            }
            for (int i = 0; i < 31; i++)
            {
                Console.WriteLine((i+1) + ": " + fibonacci[i]);
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("what would you like to run?");
            string Prog_run;
            do
            {
                Prog_run = Console.ReadLine();
                switch (Prog_run)
                {
                    case "1":
                        Console.Clear();
                        Q1();
                        break;
                    
                    case "2":
                        Console.Clear();
                        Q2();
                        break;

                    default:
                        Console.WriteLine("invalid answer, try again");
                        break;
                }
            } while (Prog_run != "1" && Prog_run != "2");
        }
    }
}
