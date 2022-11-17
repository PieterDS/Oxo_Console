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

            oxoGame.Board.DrawBoard();

            while (Analyzer.CheckWinning(oxoGame.Board) == false && Analyzer.CheckDraw(oxoGame.Board) == false) 
            {
                oxoGame.Turn();
            }

            if (oxoGame.State.GetValue() == 'X')
                Console.WriteLine("Player 1 Wins!");
            else if (oxoGame.State.GetValue() == 'O')
                Console.WriteLine("Player 2 Wins!");
            else if (Analyzer.CheckDraw(oxoGame.Board) == true)
                Console.WriteLine("It's a Draw!");
            else
                Console.WriteLine("ERROR 3524");

            Console.ReadKey();
        }
    }
}
