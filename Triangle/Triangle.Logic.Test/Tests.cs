using NUnit.Framework;
using Triangle.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle.Logic.Test
{
    [TestFixture]
    public class Tests
    {
        private Shape triangle;
        private ulong a, b, c;

        [SetUp]
        public void Init()
        {
            triangle = new Shape();
        }

        private bool[] Act(ulong a, ulong b, ulong c, Func<ulong, ulong, ulong, bool> func)
        {
            var result = new bool[6];
            result[0] = func(a, b, c);
            result[1] = func(a, c, b);
            result[2] = func(b, a, c);
            result[3] = func(c, a, b);
            result[4] = func(b, c, a);
            result[5] = func(c, b, a);
            return result;
        }

        private void CustomAssert(bool expexted, bool[] results)
        {
            foreach (var actual in results)
            {
                Assert.AreEqual(expexted, actual);
            }
        }

        //Triangle
        [Test]
        public void IsTriangle_NotTriangle()
        {
            a = 2; b = 3; c = 5;
            var results = Act(a, b, c, triangle.IsValidTriangle);
            CustomAssert(false, results);
        }

        [Test]
        public void IsTriangle_NotTriangle_False()
        {
            a = 2; b = 3; c = 10;
            var results = Act(a, b, c, triangle.IsValidTriangle);
            CustomAssert(false, results);
        }

        [Test]
        public void IsTriangle_Zero_False()
        {
            a = 2; b = 0; c = 5;
            var results = Act(a, b, c, triangle.IsValidTriangle);
            CustomAssert(false, results);
        }


        [Test]
        public void IsTriangle_Triangle()
        {
            a = 4; b = 3; c = 5;
            var results = Act(a, b, c, triangle.IsValidTriangle);
            CustomAssert(true, results);
        }

        //Isosceles
        [Test]
        public void IsIsosceles_AllEqual_true()
        {
            a = 5; b = 5; c = 5;
            var results = Act(a, b, c, triangle.IsIsosceles);
            CustomAssert(true, results);
        }

        [Test]
        public void IsIsosceles_TwoEqual_True()
        {
            a = 5; b = 5; c = 4;
            var results = Act(a, b, c, triangle.IsIsosceles);
            CustomAssert(true, results);
        }

        [Test]
        public void IsIsosceles_False()
        {
            a = 5; b = 3; c = 4;
            var results = Act(a, b, c, triangle.IsIsosceles);
            CustomAssert(false, results);
        }

        [Test]
        public void IsIsosceles_NotExist_False()
        {
            a = 2; b = 2; c = 6;
            var results = Act(a, b, c, triangle.IsIsosceles);
            CustomAssert(false, results);
        }

        //Equilateral
        [Test]
        public void IsEquilateral_True()
        {
            a = 5; b = 5; c = 5;
            var results = Act(a, b, c, triangle.IsEquilateral);
            CustomAssert(true, results);
        }

        [Test]
        public void IsEquilateral_False()
        {
            a = 5; b = 3; c = 4;
            var results = Act(a, b, c, triangle.IsEquilateral);
            CustomAssert(false, results);
        }

        [Test]
        public void IsEquilateral_Zero_False()
        {
            a = 0; b = 0; c = 0;
            var results = Act(a, b, c, triangle.IsEquilateral);
            CustomAssert(false, results);
        }

    }
}
