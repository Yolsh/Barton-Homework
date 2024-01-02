using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;

namespace A112
{
    internal class A112
    {
        static void Main(string[] args)
        {
            List<string> file = getFile();
            CountVowels(file);
            ReplaceAllVowels(file);
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

        static void ReplaceAllVowels(List<string> file)
        {
            string[] changed = new string[file.Count];
            for (int i = 0; i < file.Count; i++)
            {
                changed[i] = Regex.Replace(file[i], "a|e|i|o|u|A|E|I|O|U", "");
            }
            using (StreamWriter sw = new StreamWriter("vowels.txt", true))
            {
                foreach (string line in changed)
                {
                    sw.Write(line);
                }
            }
        }

        static void CountVowels(List<string> file)
        {
            string matches = "";
            int[] matchCount = new int[5];
            foreach (string line in file)
            {
                matches = Regex.Matches(line, "a|e|i|o|u|A|E|I|O|U").ToString().ToLower();
            }
            foreach (char vowel in matches)
            {
                switch (vowel)
                {
                    case 'a': matchCount[0]++; break;
                    case 'e': matchCount[1]++; break;
                    case 'i': matchCount[2]++; break;
                    case 'o': matchCount[3]++; break;
                    case 'u': matchCount[4]++; break;
                }
            }
            writeAnswer(matchCount);
        }
    }
}
