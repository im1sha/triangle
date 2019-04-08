using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle.Logic
{
    class InputParser
    {
        public bool AreSidesInCorrect(ulong a, ulong b, ulong c)
        {
            ulong[] values = new[] { a, b, c };

            foreach (var item in values)
            {
                if (item > ulong.MaxValue / 2 || item < 1)
                {
                    return false;
                }
            }

            return true;
        }

    }
}
