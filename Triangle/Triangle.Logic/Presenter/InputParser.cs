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

        internal string DeleteNulls(string text)
        {
            if (text.All(ch => ch == '0'))
            {
                return string.Empty;
            }
            char[] textAsArray = text.ToArray();
            int startIndex = Array.FindIndex(textAsArray, 0, ch => ch != '0');
            return new string(textAsArray, startIndex, text.Length - startIndex);
        }
    }
}
