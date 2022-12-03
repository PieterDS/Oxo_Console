using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OXO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = Input.GetSize();
            Game oxoGame = new Game(size);

            Game.Intro();

            oxoGame.GameBoard.DrawBoard();

            while (Analyzer.CheckWinning(oxoGame.GameBoard) == false && Analyzer.CheckDraw(oxoGame.GameBoard) == false) 
            {
                oxoGame.Turn();
            }

            if (oxoGame.GameState.GetValue() == 'X')
                Console.WriteLine("Player 1 Wins!");
            else if (oxoGame.GameState.GetValue() == 'O')
                Console.WriteLine("Player 2 Wins!");
            else if (Analyzer.CheckDraw(oxoGame.GameBoard) == true)
                Console.WriteLine("It's a Draw!");
            else
                Console.WriteLine("ERROR 3524");

            Console.ReadKey();
        }
    }
}
