using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;
using Triangle.Core.Model;
using Triangle.Core.Presenter;

  
namespace Triangle.Logic.Test
{
    [TestFixture]
    class Positive
    {
        TypeDeterminer model = new TypeDeterminer();

        [TestCase(SideHandler.MinValue, 2ul, 4ul, TriangleType.Invalid)]
        [TestCase(4ul, 21ul, 42ul, TriangleType.Invalid)]
        [TestCase(SideHandler.MaxValue, 10ul, 20ul, TriangleType.Invalid)]
        [TestCase(SideHandler.MinValue, 2ul, 2ul + SideHandler.MinValue, TriangleType.Invalid)]
        [TestCase(100ul, 200ul, 100ul + 200ul, TriangleType.Invalid)]
        [TestCase(SideHandler.MaxValue, 100ul, SideHandler.MaxValue - 100, TriangleType.Invalid)]
        public void IsInvalid(ulong a, ulong b, ulong c, TriangleType type)
        {
            Assert.AreEqual(type, model.GetTriangleType(a, b, c));
            Assert.AreEqual(type, model.GetTriangleType(a, c, b));
            Assert.AreEqual(type, model.GetTriangleType(b, a, c));
            Assert.AreEqual(type, model.GetTriangleType(c, a, b));
            Assert.AreEqual(type, model.GetTriangleType(b, c, a));
            Assert.AreEqual(type, model.GetTriangleType(c, b, a));
        }


        [TestCase(SideHandler.MinValue, SideHandler.MinValue, SideHandler.MinValue, TriangleType.Equilateral)]
        [TestCase(6ul, 6ul, 6ul, TriangleType.Equilateral)]
        [TestCase(42ul, 42ul, 42ul, TriangleType.Equilateral)]
        [TestCase(SideHandler.MaxValue, SideHandler.MaxValue, SideHandler.MaxValue, TriangleType.Equilateral)]
        public void IsEquilateral(ulong a, ulong b, ulong c, TriangleType type)
        {
            Assert.AreEqual(type, model.GetTriangleType(a, b, c));
        }

        [TestCase(SideHandler.MinValue, 100ul, 100ul, TriangleType.Isosceles)]
        [TestCase(21ul, 21ul, 10ul, TriangleType.Isosceles)]
        [TestCase(SideHandler.MaxValue - 1, SideHandler.MaxValue, SideHandler.MaxValue, TriangleType.Isosceles)]
        public void IsIsosceles(ulong a, ulong b, ulong c, TriangleType type)
        {
            Assert.AreEqual(type, model.GetTriangleType(a, b, c));
            Assert.AreEqual(type, model.GetTriangleType(a, c, b));
            Assert.AreEqual(type, model.GetTriangleType(b, a, c));
            Assert.AreEqual(type, model.GetTriangleType(c, a, b));
            Assert.AreEqual(type, model.GetTriangleType(b, c, a));
            Assert.AreEqual(type, model.GetTriangleType(c, b, a));
        }

        [TestCase(2ul, 3ul, 4ul, TriangleType.Scalene)]
        [TestCase(42ul, 43ul, 44ul, TriangleType.Scalene)]
        [TestCase(SideHandler.MaxValue - 2, SideHandler.MaxValue - 1, SideHandler.MaxValue, TriangleType.Scalene)]
        public void IsScalene(ulong a, ulong b, ulong c, TriangleType type)
        {
            Assert.AreEqual(type, model.GetTriangleType(a, b, c));
            Assert.AreEqual(type, model.GetTriangleType(a, c, b));
            Assert.AreEqual(type, model.GetTriangleType(b, a, c));
            Assert.AreEqual(type, model.GetTriangleType(c, a, b));
            Assert.AreEqual(type, model.GetTriangleType(b, c, a));
            Assert.AreEqual(type, model.GetTriangleType(c, b, a));
        }

    }
}


