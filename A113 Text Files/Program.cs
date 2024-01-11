using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace A113_Text_Files
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Out();
            Console.ReadKey();
        }
        static void Out()
        {
            List<string> file = ReadFile();
            Console.WriteLine($"The person with the Highest score is: {HighestScoreName(file)}");
            Console.WriteLine($"The Highest Score on 25/12/2019: {ScoreForDate("25/12/2019", file)}");
            Console.WriteLine($"BoB Has Played {NumberPlayed("BoB", file)} times");
            Console.WriteLine($"Average Score in 2020: {AverageYear(2020, file)}");
            Console.WriteLine($"Highest Score on a Leap day: {HighestLeapDay(file)}");
        }

        static List<string> ReadFile()
        {
            List<string> output = new List<string>();
            using(StreamReader sw = new StreamReader("A113HighScores.txt"))
            {
                while (!sw.EndOfStream)
                {
                    output.Add(sw.ReadLine());
                }
            }
            return output;
        }

        static string HighestScoreName(List<string> file)
        {
            int Highest = 0;
            string ans = "";
            foreach (string line in file)
            {
                int current = int.Parse(line.Substring(6,6));
                if (current > Highest)
                {
                    Highest = current;
                    ans = line.Substring(1, 3);
                }
            }
            return ans;
        }

        static int ScoreForDate(string date, List<string> file)
        {
            int Highest = 0;
            foreach (string line in file)
            {
                int current = int.Parse(line.Substring(6, 6));
                if (line.Contains(date) && current > Highest)
                {
                    Highest = current;
                }
            }
            return Highest;
        }

        static int NumberPlayed(string name, List<string> file)
        {
            int total = 0;
            foreach(string line in file)
            {
                if (line.Substring(1,3) == name) total++;
            }
            return total;
        }

        static double AverageYear(int year, List<string> file)
        {
            int total = 0;
            int finds = 0;
            foreach (string line in file)
            {
                if (int.Parse(line.Substring(19, 4)) == year)
                {
                    total += int.Parse(line.Substring(6, 6));
                    finds++;
                }
            }
            return total/finds;
        }

        static int HighestLeapDay(List<string> file)
        {
            int Highest = 0;
            foreach (string line in file)
            {
                if (Regex.IsMatch(line, "29/[0-99]") && int.Parse(line.Substring(6, 6)) > Highest)
                {
                    Highest = int.Parse(line.Substring(6, 6));
                }
            }
            return Highest;
        }
    }
}
