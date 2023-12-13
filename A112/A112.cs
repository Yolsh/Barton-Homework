using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace A112
{
    internal class A112
    {
        static void Main(string[] args)
        {
            List<string> file = getFile();
            writeAnswer(CountVowels(FindAllVowels(file)));
            foreach (string line in file)
            {
                Console.WriteLine(line);
            }
            Console.ReadKey();
        }
        static List<string> getFile()
        {
            List<string> file = new List<string>();
            using (StreamReader sr = new StreamReader("grinch1.txt"))
            {
                while (!sr.EndOfStream)
                {
                    file.Add(sr.ReadLine());
                }
            }
            return file;
        }
        static void writeAnswer(int[] vowelNums)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            using (StreamWriter sw = new StreamWriter("vowels.txt"))
            {
                for (int i = 0; i < 5; i++)
                {
                    sw.WriteLine($"There are {vowelNums[i]} {vowels[i]}'s in the file");
                }
            }
        }

        static char[] FindAllVowels(List<string> file)
        {
            char[] vowels = {'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            string allVowels = "";
            foreach (string line in file)
            {
                for (int i = 0; i < line.Length; i++)
                {
                    if (vowels.Contains(line[i]))
                    {
                        allVowels += line[i].ToString().ToLower();
                        line.ToList().RemoveAt(i);
                    }
                }
            }
            return allVowels.ToCharArray();
        }

        static int[] CountVowels(char[] allVowels)
        {
            int[] NumOfVowels = new int[5];
            foreach(char C in allVowels)
            {
                switch (C)
                {
                    case 'a':
                        NumOfVowels[0] += 1;
                        break;
                    case 'e':
                        NumOfVowels[1] += 1;
                        break;
                    case 'i':
                        NumOfVowels[2] += 1;
                        break;
                    case 'o':
                        NumOfVowels[3] += 1;
                        break;
                    case 'u':
                        NumOfVowels[4] += 1;
                        break;
                }
            }
            return NumOfVowels;
        }
    }
}
