using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle.Logic
{
    public class Shape
    {
        public bool IsValidTriangle(ulong a, ulong b, ulong c)
        {
            if (a > 0 && b > 0 && c > 0)
            {
                return a < b + c && b < a + c && c < a + b;
            }
            return false;
        }

        public bool IsIsosceles(ulong a, ulong b, ulong c)
        {
            if (IsValidTriangle(a, b, c))
            {
                return a == b || a == c || b == c;
            }
            return false;
        }

        public bool IsEquilateral(ulong a, ulong b, ulong c)
        {
            if (IsValidTriangle(a, b, c))
            {
                return a == b && b == c;
            }
            return false;
        }


        public bool AreSidesInBounds(ulong[] values)
        {
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


