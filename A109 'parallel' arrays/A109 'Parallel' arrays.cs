using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace A109__parallel__arrays
{
    internal class Program
    {
        static int[] PlayerStatsInt = new int[6];
        static string[] PlayerStatsString = { "Strength", "Dexterity", "Constitution", "Intelligence", "Wisdom", "Charisma" };

        static void CheckStats()
        {
            int total = 0;

            foreach(int item in PlayerStatsInt)
            {
                if(item > 14)
                {
                    int points = item - 8;
                    Console.WriteLine(item + " = " + points);
                    total += points;
                }
                else if(item == 14)
                {
                    Console.WriteLine(14 + " = " + 7);
                    total += 7;
                }
                else
                {
                    Console.WriteLine(15 + " = " + 9);
                    total += 9;
                }
            }
            Console.WriteLine(total);
        }

        static void DispStats()
        {
            Console.Clear();
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(PlayerStatsString[i] + " = " + PlayerStatsInt[i]);
            }
        }

        static void scoreFill()
        {
            for (int i = 0; i < PlayerStatsString.Length; i++)
            {
                int ans;
                do
                {
                    Console.WriteLine("enter a number [8-15]");
                    Console.Write(PlayerStatsString[i] + " = ");

                    ans = int.Parse(Console.ReadLine());

                    if (ans < 15 || ans > 8)
                    {
                        PlayerStatsInt[i] = ans;
                    }
                    else
                    {
                        Console.WriteLine("that is not within the right range");
                    }
                } while (ans > 15 || ans < 8);
            }
        }

        static void Main(string[] args)
        {
            string ans;
            do
            {
                Console.WriteLine("would you Like to Continue or edit your choices [yes/no]");
                ans = Console.ReadLine().ToUpper();

                scoreFill();
                DispStats();
                Console.ReadKey();
            } while (ans == "YES");
        }
    }
}
