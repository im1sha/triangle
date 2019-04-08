using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle.Logic
{
    public class TypeDeterminer
    {
        public bool IsValidTriangle(ulong a, ulong b, ulong c)
        {
            if (HavePositiveLength(a,b,c))
            {
                return a < b + c && b < a + c && c < a + b;
            }
            return false;
        }

        public bool IsIsosceles(ulong a, ulong b, ulong c)
        {
            return a == b || a == c || b == c;
        }

        public bool IsEquilateral(ulong a, ulong b, ulong c)
        {
            return a == b && b == c;
        }

        private bool HavePositiveLength(ulong a, ulong b, ulong c)
        {
            return a > 0 && b > 0 && c > 0;
        }    
    }
}


