using System.Transactions;

namespace OXO
{
    internal class Game
    {
        public State GameState { get; }
        public Board GameBoard { get; }

        public Game(int size)
        {           
            GameBoard = new Board(size);
            GameState = new State();            
        }

        public void Turn()
        {
            int rowIndex;
            int columnIndex;

            GameState.ChangeState();

            do
            {
                Input.GetSymbol(GameState);
                rowIndex = Input.GetRowIndex(GameBoard.OxoBoard.GetLength(0)) - 1;
                columnIndex = Input.GetColumnIndex(GameBoard.OxoBoard.GetLength(0)) - 1;

                if (GameBoard.OxoBoard[rowIndex, columnIndex] != ' ')
                    Console.WriteLine("The submitted values were wrong, please try again!");
            }
            while (GameBoard.OxoBoard[rowIndex, columnIndex] != ' ');
            
            GameBoard.SetBoardValue(rowIndex, columnIndex, GameState);
            GameBoard.DrawBoard();            
        }        

        public static void Intro()
        {
            Console.WriteLine("Welcome to the official OXO game!");
            Console.WriteLine("This game is played by 2 players. The first one to create OXO wins!");
            Console.WriteLine("The first player sets an X on the board, the second one an O.");
            Console.WriteLine("Ready, set, go!!!");            
        }            
    }
}
