using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A109
{
    internal class A109
    {
        struct PlayerStats
        {
            public string[] Names;
            public int[] Values;
            public int PointsAllowed;
        }

        static PlayerStats UserFillStats()
        {
            PlayerStats PlayerStat;
            Console.WriteLine("how many stats would you like to have?");
            int PlayerStatNum = int.Parse(Console.ReadLine());

            PlayerStat.Names = new string[PlayerStatNum];
            PlayerStat.Values = new int[PlayerStatNum];

            for (int i = 0; i < PlayerStatNum; i++)
            {
                Console.WriteLine("What would you like stat " + (i+1) + " to be?");
                PlayerStat.Names[i] = Console.ReadLine();
                Console.WriteLine("and what should it be worth");
                int val = int.Parse(Console.ReadLine());
                if (val <= 15 && val >= 8) PlayerStat.Values[i] = val;
                else 
                {
                    Console.WriteLine("not a valid input, try again:");
                    i--;
                }
            }
            Console.WriteLine("what should the total points allowed be ?");
            PlayerStat.PointsAllowed = int.Parse(Console.ReadLine());

            return PlayerStat;
        }

        static void StatsPointsCheck(PlayerStats stats)
        {
            int total = 0;
            foreach (int item in stats.Values)
            {
                if (item <= 13) total += item - 8;
                else if (item == 14) total += item - 7;
                else total += item - 6;
            }
            if (total > stats.PointsAllowed) Console.WriteLine("your attributes are to mighty try making your charecter weaker");
            else Console.WriteLine("well done you can exit now as your player stats are valid");
        }

        static PlayerStats DispPlayerStats(PlayerStats stats)
        {
            Console.Clear();
            for (int i = 0; i < stats.Names.Length; i++)
            {
                Console.WriteLine(stats.Names[i] + " = " + stats.Values[i]);
            }
            return stats;
        }

        static void Main(string[] args)
        {
            string ans;
            do
            {
                Console.WriteLine("Would you like to run the program? [yes/no]");
                ans = Console.ReadLine().ToUpper();

                StatsPointsCheck(DispPlayerStats(UserFillStats()));
                Console.ReadKey();
                Console.Clear();
            } while (ans != "NO");
            Environment.Exit(0);
        }
    }
}
