using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A102
{
    internal class A102
    {
        static void Main(string[] args)
        {
            Console.WriteLine("pick a program");
            int Prog_run = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (Prog_run)
            {
                case 0:
                    Console.WriteLine("what colour is the light currently?");
                    string Colour_now = Console.ReadLine();

                    switch (Colour_now)
                    {
                        case "Red":
                            Console.WriteLine("Amber");
                            break;

                        case "RedAmber":
                            Console.WriteLine("Green");
                            break;
                        case "Green":
                            Console.WriteLine("Amber");
                            break;
                        case "Amber":
                            Console.WriteLine("Red");
                            break;
                    }
                    break;

                case 1:
                    int score = 0;
                    Console.WriteLine("how tall is the eiffel tower?");
                    Console.WriteLine("A - 275m");
                    Console.WriteLine("B - 330m");
                    Console.WriteLine("C - 105m");
                    string ans1 = Console.ReadLine();

                    if (ans1 == "B")
                    {
                        Console.WriteLine("Correct");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect, the answer was B");
                    }

                    Console.WriteLine("whats the capital of Nigeria?");
                    Console.WriteLine("A - Abuja");
                    Console.WriteLine("B - Lagos");
                    Console.WriteLine("C - Africa");
                    string ans2 = Console.ReadLine();

                    if (ans2 == "A")
                    {
                        Console.WriteLine("Correct");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect, the answer was A");
                    }

                    Console.WriteLine("Who diccovered plancks constant?");
                    Console.WriteLine("A - Planckton");
                    Console.WriteLine("B - Max Planck");
                    Console.WriteLine("C - Alexander Flemming");
                    string ans3 = Console.ReadLine();

                    if (ans3 == "B")
                    {
                        Console.WriteLine("Correct");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect, the answer was B");
                    }

                    Console.WriteLine((score == 3) ? "Well done full marks" : "you failure you only got: " + score);

                    break;

            }

            Console.ReadKey();

        }
    }
}
