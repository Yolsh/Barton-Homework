using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A131
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Encode("WAVE", "microwaves"));
            Console.WriteLine(Encode("I love cows", "microwaves"));
            Console.WriteLine(Encode("microwaves", "microwaves"));

            Console.WriteLine(EncodePairs("my secret"));
            Console.ReadKey();
        }

        static string Encode(string s, string key)
        {
            if (key.Length % 2 != 0) throw new Exception();

            Dictionary<char, char> encoder = new Dictionary<char, char>();
            string newS = "";

            key = key.ToLower();
            for (int i = 0; i < key.Length; i+=2)
            {
                encoder.Add(key[i], key[i+1]);
            }

            key = key.ToUpper();
            for (int i = 0; i < key.Length; i += 2)
            {
                encoder.Add(key[i], key[i + 1]);
            }

            foreach (char c in s)
            {
                if (encoder.Keys.Contains(c))
                {
                    newS += encoder[c];
                    continue;
                }
                else if (encoder.Values.Contains(c))
                {
                    newS += encoder.First(x => x.Value == c).Key;
                    continue;
                }
                newS += c;
            }
            return newS;
        }

        static string EncodePairs(string s)
        {
            string NewS = "";
            for (int i = 0; i < (s.Length % 2 == 0 ? s.Length : s.Length-1); i+=2)
            {
                NewS += s[i + 1];
                NewS += s[i];
            }
            return NewS.Length == s.Length ? NewS : NewS + s.Last();
        }
    }
}
