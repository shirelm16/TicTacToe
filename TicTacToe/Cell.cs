using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Cell
    {
        public char Value { get; private set; } = ' ';
        
        public void SetValue(char value)
        {
            if(IsValidValue(value))
                Value = value;
        }

        public bool IsEmpty()
        {
            return Value ==  ' ';
        }

        private bool IsValidValue(char value)
        {
            return value == 'X' || value == 'O';
        }
    }
}
