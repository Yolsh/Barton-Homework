using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Collections.Specialized;

namespace A107__Will_HW_
{
    internal class Program
    {
        static void Q2()
        {
            int PlayerOneScore = 0;
            int PlayerTwoScore = 0;
            Console.WriteLine("How many games?");
            int NoOfGamesInMatch = int.Parse(Console.ReadLine());
            for (int i = 0; i < NoOfGamesInMatch; i++)
            {
                Console.WriteLine("Did Player One win the game (enter Y or N)?");
                string PlayerOneWinsGame = Console.ReadLine();
                if (PlayerOneWinsGame == "Y")
                {
                    PlayerOneScore = PlayerOneScore + 1;
                }
                else
                {
                    PlayerTwoScore = PlayerTwoScore + 1;
                }

            }
            Console.WriteLine(PlayerOneScore);
            Console.WriteLine(PlayerTwoScore);
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Q2();
            Environment.Exit(0);
            string x = "true";
            int total = 0;
            string name;
            Console.WriteLine("Enter done to end program");
            while (x == "true")
            {
                Console.WriteLine("Enter name");
                name = Console.ReadLine();
                Thread.Sleep(200);
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
