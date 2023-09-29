using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _21._09._23_Homework_A101
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what program would you like to run?");
            int Prog_run = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (Prog_run)
            {
                case 0:
                    Console.WriteLine("provide a number:");
                    int First = int.Parse(Console.ReadLine());

                    Console.WriteLine("and another number:");
                    int Second = int.Parse(Console.ReadLine());

                    if (First > Second)
                    {
                        Console.WriteLine("First");
                    }

                    else if (First < Second)
                    {
                        Console.WriteLine("Second");
                    }

                    else
                    {
                        Console.WriteLine("those are equivalent");
                    }

                    break;
                case 1:
                    Console.WriteLine("provide a number");
                    int Num1 = int.Parse(Console.ReadLine());

                    if (Num1 < 5000 && Num1 > 1000)
                    {
                        Console.WriteLine("Correct");
                    }

                    else if (Num1 < 1000)
                    {
                        Console.WriteLine("Too small");
                    }

                    else
                    {
                        Console.WriteLine("Too big");
                    }

                    break;

                case 2:
                    Console.WriteLine("What was the diameter of the pizza?");
                    int Radius = (int.Parse(Console.ReadLine()))/2;

                    Console.WriteLine("How many slices was the pizza cut into?");
                    int Total_slices = int.Parse(Console.ReadLine());

                    Console.WriteLine("How many slices did you eat?");
                    int Slices_eaten = int.Parse(Console.ReadLine());

                    double Total_volume = Math.PI * Radius * Radius * 2;
                    double Consumed = Total_volume * (Slices_eaten / Total_volume);

                    Console.WriteLine(Consumed + "cm^3 of pizza consumed");

                    break;

                default:
                    Console.WriteLine("Invalid input");
                    break;
            }

            Console.ReadKey();
        }
    }
}
