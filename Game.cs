using System.Transactions;

namespace OXO
{
    internal class Game
    {
        public State State { get; }
        public Board Board { get; }

        public Game(int size)
        {           
            Board = new Board(size);
            State = new State();            
        }

        public void Turn()
        {
            int rowIndex;
            int columnIndex;

            State.ChangeState();

            do
            {
                Input.GetSymbol(State);
                rowIndex = Input.GetRowIndex(Board.OxoBoard.GetLength(0)) - 1;
                columnIndex = Input.GetColumnIndex(Board.OxoBoard.GetLength(0)) - 1;

                if (Board.OxoBoard[rowIndex, columnIndex] != ' ')
                    Console.WriteLine("The submitted values were wrong, please try again!");
            }
            while (Board.OxoBoard[rowIndex, columnIndex] != ' ');
            
            Board.SetBoardValue(rowIndex, columnIndex, State);
            Board.DrawBoard();            
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
