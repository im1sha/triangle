using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triangle.Core.Model;

namespace Triangle.Core.Presenter
{
    public static class TypeToMessageConverter
    {
        private const string INVALID_TRINGLE_MESSAGE = 
            "Введите такие значения длин сторон, для которых верно:" +
            " сумма любых двух сторон больше третьей стороны";
        private const string EQUILATERAL_TRIANGLE_MESSAGE = "Равносторонний треугольник";
        private const string ISOSCELES_TRIANGLE_MESSAGE = "Равнобедренный треугольник";
        private const string SCALENE_TRIANGLE_MESSAGE = "Неравносторонний треугольник";

        public static string GetMessageByTriangleType(TriangleType triangleType)
        {
            switch (triangleType)
            {
                case TriangleType.Invalid:
                    return INVALID_TRINGLE_MESSAGE;
                case TriangleType.Isosceles:
                    return ISOSCELES_TRIANGLE_MESSAGE;
                case TriangleType.Equilateral:
                    return EQUILATERAL_TRIANGLE_MESSAGE;
                default:
                    return SCALENE_TRIANGLE_MESSAGE;
            }
        }                  
    }
}


