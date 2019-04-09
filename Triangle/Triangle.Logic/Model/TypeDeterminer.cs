using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle.Core.Model
{
    public enum TriangleType { Invalid, Isosceles, Equilateral, Scalene }

    public class TypeDeterminer
    {
        public TriangleType GetTriangleType(ulong a, ulong b, ulong c)
        {
            if (!IsValidTriangle(a, b, c))
            {
                return TriangleType.Invalid;
            }

            if (IsEquilateral(a, b, c))
            {
                return TriangleType.Equilateral;
            }

            if (IsIsosceles(a, b, c))
            {
                return TriangleType.Isosceles;
            }

            return TriangleType.Scalene;
        }

        private bool IsValidTriangle(ulong a, ulong b, ulong c)
        {
            if (HavePositiveLengths(a, b, c))
            {
                return a < b + c && b < a + c && c < a + b;
            }
            return false;
        }

        private bool IsIsosceles(ulong a, ulong b, ulong c)
        {
            return a == b || a == c || b == c;
        }

        private bool IsEquilateral(ulong a, ulong b, ulong c)
        {
            return a == b && b == c;
        }

        private bool HavePositiveLengths(ulong a, ulong b, ulong c)
        {
            return (new [] { a, b, c }).All(item => item > 0);
        }    
    }
}


