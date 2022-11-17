using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OXO
{
    enum EnumState { X, O };

    internal class State
    {
        EnumState oxoState;

        public State() // The start state is X!
        {
            oxoState = EnumState.O;            
        }

        public void ChangeState() // Changes the state to the other one (X --> O, O --> X)
        {
            if (oxoState == EnumState.X)
                oxoState = EnumState.O;
            else
                oxoState = EnumState.X;
        }

        public char GetValue() // Retuns the current state as a char!
        {
            if (oxoState == EnumState.X)
                return 'X';
            else
                return 'O';                
        }
        
    }
}
