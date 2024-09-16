using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A135
{
    internal class Program
    {
        static char[,] Decoder;
        static Dictionary<char, int[]> Encoder;
        static void Main(string[] args)
        {
            Decoder = new char[5, 5];
            Encoder = new Dictionary<char, int[]>();
            int count = 65;
            for (int i = 0; i < Decoder.GetLength(0); i++)
            {
                for (int j = 0; j < Decoder.GetLength(1); j++)
                {
                    if (i == 2 && j == 0) count++;
                    Decoder[i, j] = (char)count;
                    int[] vals = { i, j };
                    Encoder.Add((char)count, vals);
                    count++;
                }
            }

            Console.WriteLine(TapDecodeLetter(". ... ... .... .... ..... ... . . ...."));
            Console.WriteLine(TapDecodeLetter(".. ... ... .... ... .... .... ...."));
            Console.WriteLine(TapDecodeLetter("... ..... . . ... ... .. .... . ..."));
            Console.WriteLine(TapEncodeWord("Barton"));
            Console.WriteLine(TapDecodeLetter(". .. . . .... .. .... .... ... .... ... ..."));
            Console.ReadKey();
        }

        static string TapDecodeLetter(string code) => code.Split(' ').Select((x, i) => i % 2 == 0 ? Decoder[x.Length-1, code.Split(' ')[i+1].Length-1].ToString() : "").Aggregate((total, c) => total + c);
        static string TapEncodeWord(string word) => word.ToUpper().ToCharArray().Select(x => Enumerable.Repeat(".", Encoder[x][0]+1).Aggregate((total, c) => total + c) + " " + Enumerable.Repeat(".", Encoder[x][1]+1).Aggregate((total, c) => total + c) + " ").Aggregate((total, c) => total + c);
    }
}
