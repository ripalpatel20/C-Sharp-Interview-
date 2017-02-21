using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rudedog2.Battleship
{
    class Program
    {
        static void Main(string[] args)
        {
            RunUserCode();
            Console.ReadLine();
        }

        static int[,] sea;

        static int BATTLESHIP = 2;
        static int CRUISER = 3;
        static int SUBMARINE = 4;
        static int ROWINGBOAT = 5;
        static int SEA_SIZE = 10;
        static int EMPTY_SEA = 0;
        static int ROW;
        static int COLUMN;
        static string blankRow;

        static void RunUserCode()
        {
            Console.WriteLine("Welcome to Battleships");
            sea = new int[SEA_SIZE, SEA_SIZE];
            blankRow = new string(Char.Parse(" "), (SEA_SIZE * 2) + 2);

            sea[0, 5] = BATTLESHIP;
            sea[2, 7] = BATTLESHIP;
            sea[0, 0] = CRUISER;
            sea[2, 0] = CRUISER;
            sea[4, 3] = CRUISER;
            sea[5, 6] = SUBMARINE;
            sea[8, 8] = ROWINGBOAT;

            DrawGameBoard();
        }

        private static void DrawGameBoard()
        {
            DrawColumnHeaders();
            for (ROW = EMPTY_SEA; ROW < SEA_SIZE; ROW++)
            {
                Console.Write(Environment.NewLine);
                string rowHeader = ROW.ToString() + " ";
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(rowHeader);
                Console.ResetColor();

                Console.BackgroundColor = ConsoleColor.DarkCyan;
                for (COLUMN = EMPTY_SEA; COLUMN < SEA_SIZE; COLUMN++)
                {
                    int cellContent = sea[COLUMN, ROW];
                    if (cellContent > 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(cellContent + " ");
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    else
                    {
                        Console.Write(cellContent + " ");
                    }
                }
                Console.Write(Environment.NewLine);
                Console.Write(blankRow);
                Console.ResetColor();
            }
            Console.Write(Environment.NewLine);
        }

        private static void DrawColumnHeaders()
        {
            Console.WriteLine();
            string Header = "  ";
            Console.Write(Header);

            for (ROW = EMPTY_SEA; ROW < SEA_SIZE; ROW++)
            {
                string rowHeader = ROW.ToString() + " ";
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(rowHeader);
                Console.ResetColor();

            }
        }
    }
}