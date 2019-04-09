using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triangle.Core.Model;
using Triangle.Core.Presenter;

namespace Triangle.Logic.Test
{
    class NotATriangle
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

    }
}
