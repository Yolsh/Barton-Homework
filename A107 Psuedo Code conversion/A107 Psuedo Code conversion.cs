using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A107_Psuedo_Code_conversion
{
    internal class Program
    {
        static void Q1() 
        {
            int PlayerOneScore = 0;
            int PlayerTwoScore = 0;
            Console.WriteLine("How many games?");
            int NoOfGamesInMatch = int.Parse(Console.ReadLine());
            for(int NoOfGamesPlayed = 1; NoOfGamesPlayed <= NoOfGamesInMatch; NoOfGamesPlayed++)
            {
                Console.WriteLine("Did Player One win the game (enter Y or N) ?");
                char PlayerOneWinsGame = Console.ReadKey().KeyChar;
                if (PlayerOneWinsGame == 'Y')
                {
                    PlayerOneScore++;
                }
                else
                {
                    PlayerTwoScore++;
                }
            }
            Console.WriteLine(PlayerOneScore);
            Console.WriteLine(PlayerTwoScore);
            Console.ReadKey();
        }

        static void Q2()
        {
            Console.WriteLine("The first few prime numbers are:");
            for (int Count1 = 2; Count1 < 51; Count1++)
            {
                int Count2 = 2;
                string Prime = "Yes";
                while(Count2 * Count2 <= Count1)
                {
                    if(Count1 % Count2 == 0)
                    {
                        Prime = "No";
                    }
                    Count2++;
                }
                if (Prime == "Yes")
                {
                    Console.WriteLine(Count1);
                }
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("What Project would you like to run?");
            string Prog_run;
            do
            {
                Prog_run = Console.ReadLine();
                switch (Prog_run)
                {
                    case "1": Console.Clear(); Q1(); break;
                    case "2": Console.Clear(); Q2(); break;
                    default: Console.WriteLine("Not an option"); break;
                }
            }while(Prog_run != "1" && Prog_run != "2");

        }
    }
}
