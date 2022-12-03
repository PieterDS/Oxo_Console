using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OXO
{
    internal class Analyzer
    {   
        public static bool CheckWinning(Board board) // Check if there is a winning combination on the board
        {
            return (CheckRow(board) || CheckColumn(board) || CheckDiagonal(board));
        }

        public static bool CheckDraw(Board board) // check if there is a draw --> the board is full but there is no winning combination
        {
            return (CheckWinning(board) == false && CheckFull(board) == true);
        }

        private static bool CheckRow(Board board) // Check if there is a winning combination on a row
        {
            for (int rij = 0; rij < board.OxoBoard.GetLength(0); rij++)
            {
                for (int kolom = 0; kolom < board.OxoBoard.GetLength(1) - 2; kolom++) // -2 makes sure that the if loop doesn't go over the array length!
                {
                    if (board.OxoBoard[rij, kolom] == 'O' && board.OxoBoard[rij, kolom + 1] == 'X' && board.OxoBoard[rij, kolom + 2] == 'O')
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private static bool CheckColumn(Board board) // Check if there is a winning combination on a column
        {
            for (int kolom = 0; kolom < board.OxoBoard.GetLength(1); kolom++)
            {
                for (int rij = 0; rij < board.OxoBoard.GetLength(0) - 2; rij++) 
                {
                    if (board.OxoBoard[rij, kolom] == 'O' && board.OxoBoard[rij + 1, kolom] == 'X' && board.OxoBoard[rij + 2, kolom] == 'O')
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private static bool CheckDiagonal(Board board) // Check if there is a winning combination on a diagonal (Top left --> bottom Right | bottom left --> Top right)
        {
            
            for (int rij = 0; rij < board.OxoBoard.GetLength(0) - 2; rij++) // (Top left-- > bottom Right)
            {
                for (int kolom = 0; kolom < board.OxoBoard.GetLength(1) - 2; kolom++) 
                {
                    if (board.OxoBoard[rij, kolom] == 'O' && board.OxoBoard[rij + 1, kolom + 1] == 'X' && board.OxoBoard[rij + 2, kolom + 2] == 'O')
                    {
                        return true;
                    }
                }
            }

            for (int rij = 2; rij < board.OxoBoard.GetLength(0); rij++) // (bottom left --> Top right)
            {
                for (int kolom = 2; kolom < board.OxoBoard.GetLength(1); kolom++)
                {
                    if (board.OxoBoard[rij, kolom] == 'O' && board.OxoBoard[rij - 1, kolom - 1] == 'X' && board.OxoBoard[rij - 2, kolom - 2] == 'O')
                    {
                        return true;
                    }
                }
            }

            return false;
        }        

        private static bool CheckFull(Board board) 
        {
            bool full = true;

            foreach(char symbol in board.OxoBoard)
            {
                if (symbol != 'O' && symbol != 'X')
                    full = false;
            }

            return full;
        }
    }
}
