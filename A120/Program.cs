using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A120
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] Board = new int[5, 5];
            FillBoard(Board);
            PrintBoard(Board, GetHighestRow(Board), GetHighestColumn(Board));
            Console.ReadKey();
        }

        static void FillBoard(int[,] Board)
        {
            Random rand = new Random();

            for (int i = 0; i < Board.GetLength(0); i++)
            {
                for (int j = 0; j < Board.GetLength(1); j++)
                {
                    Board[i, j] = rand.Next(10, 100);
                }
            }
        }

        static void PrintBoard(int[,] Board, int row, int column)
        {
            for (int i = 0; i < Board.GetLength(0); i++)
            {
                int RowTotal = 0;
                for (int j = 0; j < Board.GetLength(1); j++)
                {
                    if (i == row && j == column)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    else if (j == column)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                    }
                    else if (i == row)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    Console.Write($"|{Board[i, j]}|");
                    RowTotal += Board[i, j];
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.Write(RowTotal);
                Console.WriteLine();
            }
        }

        static int GetHighestRow(int[,] Board)
        {
            int Biggest = 0;
            int row = 0;
            for (int i = 0; i < Board.GetLength(0); i++)
            {
                int RowTotal = 0;
                for (int j = 0; j < Board.GetLength(1); j++)
                {
                    RowTotal += Board[i, j];
                }
                if (RowTotal > Biggest)
                {
                    Biggest = RowTotal;
                    row = i;
                }
            }
            return row;
        }

        static int GetHighestColumn(int[,] Board)
        {
            int Biggest = 0;
            int column = 0;
            for (int i = 0; i < Board.GetLength(1); i++)
            {
                int ColumnTotal = 0;
                for (int j = 0; j < Board.GetLength(0); j++)
                {
                    ColumnTotal += Board[j, i];
                }
                if (ColumnTotal > Biggest)
                {
                    Biggest = ColumnTotal;
                    column = i;
                }
            }
            return column;
        }
    }
}
