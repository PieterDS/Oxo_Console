using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OXO
{
    enum StateValues { X, O };

    internal class State
    {
        private StateValues oxoState;

        public State() // The start state is X!
        {
            oxoState = StateValues.O;            
        }

        public void ChangeState() // Changes the state to the other one (X --> O, O --> X)
        {
            if (oxoState == StateValues.X)
                oxoState = StateValues.O;
            else
                oxoState = StateValues.X;
        }

        public char GetValue() // Retuns the current state as a char!
        {
            if (oxoState == StateValues.X)
                return 'X';
            else
                return 'O';                
        }        
    }
}
