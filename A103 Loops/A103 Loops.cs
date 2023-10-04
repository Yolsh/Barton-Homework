using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A103_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program select: ");
            int Prog_Run = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (Prog_Run)
            {
                case 0:
                    Console.WriteLine(" Number Please");
                    int User_num = int.Parse(Console.ReadLine());
                    int Out = 0;

                    do
                    {
                        Console.WriteLine(Out);
                        Out++;
                    } while (Out <= User_num);

                    break;

                case 1:
                    Console.WriteLine("Which power table would you like:");
                    int Base = int.Parse(Console.ReadLine());

                    Console.WriteLine("highest power you would like to see (up to 3 digits):");
                    int Upper_Power = int.Parse(Console.ReadLine());

                    for (int i = 0; i <= Upper_Power; i++)
                    {
                        if (i%2 == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                        Console.WriteLine((i < 10)? Base + "^  " + i + " = " + Math.Pow(Base, i) : (i < 100)? Base + "^ " + i + " = " + Math.Pow(Base, i) : Base + "^" + i + " = " + Math.Pow(Base, i));
                    }
            


                    break;
            }

            Console.ReadKey();
        }
    }
}
