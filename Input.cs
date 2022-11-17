using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OXO
{
    internal class Input
    {
        public static int GetSize()
        {
            Console.WriteLine("How big should the OXO board be?");
            Console.WriteLine("Enter the number of rows:");

            int size = Convert.ToInt32(Console.ReadLine());

            return size;
        }
               
        public static char GetSymbol(State state)
        {
            char symbol = ' ';

            do
            {
                Console.WriteLine("Which symbol do you want to insert: ");
                symbol = Convert.ToChar(Console.ReadLine());
            }
            while (symbol != state.GetValue());

            return symbol;
        }

        public static int GetRowIndex(int rowLimit)
        {
            int rowIndex;

            do
            {
                Console.WriteLine("On which row do you want to insert a symbol?");
                rowIndex = Convert.ToInt32(Console.ReadLine());
            }
            while (rowIndex <= 0 || rowIndex > rowLimit);
            return rowIndex;
        }

        public static int GetColumnIndex(int columnLimit)
        {
            int columnIndex;

            do
            {
                Console.WriteLine("On which column do you want to insert a symbol?");
                columnIndex = Convert.ToInt32(Console.ReadLine());
            }
            while (columnIndex <= 0 || columnIndex > columnLimit);
            return columnIndex;
        }
    }
}
