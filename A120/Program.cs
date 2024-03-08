using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A120
{
    internal class Program
    {
        static Random rand = new Random();

        static void Main(string[] args)
        {
            int[,] Board = new int[5, 5];
            FillBoard(Board);
            PrintBoard(Board, GetMax(Board, true), GetMax(Board, false));
            Console.ReadKey();
        }

        static void FillBoard(int[,] Board)
        {
            for (int i = 0; i < Board.GetLength(0); i++)
            {
                for (int j = 0; j < Board.GetLength(1); j++)
                {
                    Board[i, j] = rand.Next(10, 100);
                }
            }
        }

        static void PrintBoard(int[,] Board, int[] rows, int[] columns)
        {
            int[] RowTotals = GetTotals(Board, true);
            for (int i = 0; i < Board.GetLength(0); i++)
            {
                for (int j = 0; j < Board.GetLength(1); j++)
                {
                    if (rows.Contains(i) && columns.Contains(j))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    else if (columns.Contains(j))
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                    }
                    else if (rows.Contains(i))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    Console.Write($"|{Board[i, j]}|");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.Write(RowTotals[i]);
                Console.WriteLine();
            }
        }

        static int[] GetMax(int[,] Board, bool RorC)
        {
            List<int> Pointers = new List<int>();
            int[] Totals;
            if (RorC) Totals = GetTotals(Board, true);
            else Totals = GetTotals(Board, false);
            Pointers.Add(Array.IndexOf(Totals, Totals.Max()));
            for (int i = 0; i < Totals.Length; i ++) if (Totals[i] == Totals.Max() && i != Pointers[0]) Pointers.Add(i);
            return Pointers.ToArray();
        }

        static int[] GetTotals(int[,] Board, bool RorC)
        {
            int[] Totals = new int[Board.GetLength(0)];
            int total;
            for (int row = 0; row < Board.GetLength(0); row++)
            {
                total = 0;
                for (int col = 0; col < Board.GetLength(1); col++) 
                {
                    if (RorC) total += Board[row, col];
                    else total += Board[col, row];
                }
                Totals[row] = total;
            }
            return Totals;
        }
    }
}
