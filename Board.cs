using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OXO
{
    internal class Board
    {
        public char[,] OxoBoard { get; } // Property and implicit backing field for a 2D array consisting of characters.

        public Board(int size) // Create a new char[,] with the lenth as parameter
        {
            OxoBoard = new char[size, size];

            for (int rij = 0; rij < OxoBoard.GetLength(0); rij++)
            {
                for (int kolom = 0; kolom < OxoBoard.GetLength(1); kolom++)
                {
                    OxoBoard[rij, kolom] = ' '; // Fill the oxoboard 2D array with empty spaces
                }
            }
        }

        public void SetBoardValue(int row, int column, State oxoValue)
        {
            OxoBoard[row, column] = oxoValue.GetValue(); // Set a new value (X or O in the board)
        }

        public void DrawBoard() // This method draws an OXO board based on the oxoBoard field.
        {
            for (int row = 0; row < OxoBoard.GetLength(0); row++)
            {
                Console.Write(" ");

                for (int column = 0; column < OxoBoard.GetLength(1); column++)
                {
                    Console.Write(OxoBoard[row, column]);

                    if (column < OxoBoard.GetLength(1) - 1)
                        Console.Write(" | ");
                }

                Console.WriteLine();

                if (row < OxoBoard.GetLength(0) - 1)
                {
                    for (int column = 0; column < OxoBoard.GetLength(1); column++)
                    {
                        Console.Write("---");

                        if (column < OxoBoard.GetLength(0) - 1)
                            Console.Write("+");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
