using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle.Core.Presenter
{
    class InputParser
    {
        public int MaxInputLength { get => SideHandler.MaxValue.ToString().Length; }

        public bool IsInputValid(string currentString, char newChar)
        {
            const char backspace = (char)8;

            if (newChar == backspace)
            {
                return true;
            }

            if (currentString.Length == MaxInputLength)
            {
                return false;
            }

            return newChar >= '0' && newChar <= '9';
        }
    }
}
