using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace A119
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] Board = new char[8, 8];
            FillBoard(Board);
            PlayerPlace(Board, true);
            PlayerPlace(Board, false);
            PrintBoard(Board);
            PossibleTake(Board);
            Console.ReadKey();
        }

        static void FillBoard(char[,] Board)
        {
            for (int i = 0; i < Board.GetLength(0); i++)
            {
                for (int j = 0; j < Board.GetLength(1); j++)
                {
                    Board[i, j] = ' ';
                }
            }
        }

        static void PlayerPlace(char[,] Board, bool mode)
        {
            if (mode)
            {
                int row;
                int column;
                do
                {
                    Console.WriteLine("Row of the Rook?");
                    row = BoardCheck(Console.ReadLine());
                    Console.WriteLine("Column of the Rook?");
                    column = BoardCheck(Console.ReadLine());
                    Console.Clear();
                } while (row == -1 || column == -1);
                Board[row, column] = 'R';
            }
            else
            {
                Console.WriteLine("How many pawn pieces would you like");
                int NumPawns = int.Parse(Console.ReadLine());
                for (int i = 0; i < NumPawns; i++)
                {
                    int row;
                    int column;
                    do
                    {
                        Console.WriteLine($"Row of Pawn {i + 1}?");
                        row = BoardCheck(Console.ReadLine());
                        Console.WriteLine($"Column of Pawn {i + 1}?");
                        column = BoardCheck(Console.ReadLine());
                    } while (row == -1 || column == -1);
                    Board[row, column] = 'P';
                }
            }
        }

        static void PrintBoard(char[,] Board)
        {
            for (int i = 0; i < Board.GetLength(0); i++)
            {
                for (int j = 0; j < Board.GetLength(1); j++)
                {
                    Console.Write($"|{Board[i, j]}|");
                }
                Console.WriteLine();
            }
        }

        static void PossibleTake(char[,] Board)
        {
            for (int i = 0; i < Board.GetLength(0); i++)
            {
                for (int j = 0; j < Board.GetLength(1); j++)
                {
                    if (Board[i, j] == 'R')
                    {
                        for (int k = 0; k < Board.GetLength(0); k++)
                        {
                            if (Board[i, k] == 'P')
                            {
                                Console.WriteLine($"Rook can take Pawn at {i + 1}, {k + 1}");
                            }
                        }
                        for (int k = 0; k < Board.GetLength(1); k++)
                        {
                            if (Board[k,j] == 'P')
                            {
                                Console.WriteLine($"Rook can take Pawn at {k + 1}, {j + 1}");
                            }
                        }
                    }
                }
            }
        }

        static int BoardCheck(string num)
        {
            if (Regex.IsMatch(num, "\\d"))
            {
                int Num = int.Parse(num);
                if (Num >= 0 && Num <= 7)
                {
                    return Num - 1;
                }
                return -1;
            }
            return -1;
        }
    }
}
