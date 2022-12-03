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
        private StateValues _oxoState;

        public State() // The start state is X!
        {
            _oxoState = StateValues.O;            
        }

        public void ChangeState() // Changes the state to the other one (X --> O, O --> X)
        {
            if (_oxoState == StateValues.X)
                _oxoState = StateValues.O;
            else
                _oxoState = StateValues.X;
        }

        public char GetValue() // Retuns the current state as a char!
        {
            if (_oxoState == StateValues.X)
                return 'X';
            else
                return 'O';                
        }        
    }
}
