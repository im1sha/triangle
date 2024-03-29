﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;
using Triangle.Core.Model;
using Triangle.Core.Presenter;

  
namespace Triangle.Testing
{
    [TestFixture]
    class TypeCheck
    {
        private readonly TypeDeterminer model = new TypeDeterminer();

        [TestCase(SideHandler.MinValue, SideHandler.MinValue, SideHandler.MinValue, Core.Model.TriangleType.Equilateral)]
        [TestCase(6ul, 6ul, 6ul, Core.Model.TriangleType.Equilateral)]
        [TestCase(42ul, 42ul, 42ul, Core.Model.TriangleType.Equilateral)]
        [TestCase(SideHandler.MaxValue, SideHandler.MaxValue, SideHandler.MaxValue, Core.Model.TriangleType.Equilateral)]
        public void IsEquilateral(ulong a, ulong b, ulong c, Core.Model.TriangleType type)
        {
            Assert.AreEqual(type, model.GetTriangleType(a, b, c));
        }

        [TestCase(SideHandler.MinValue, 100ul, 100ul, Core.Model.TriangleType.Isosceles)]
        [TestCase(21ul, 21ul, 10ul, Core.Model.TriangleType.Isosceles)]
        [TestCase(SideHandler.MaxValue - 1, SideHandler.MaxValue, SideHandler.MaxValue, Core.Model.TriangleType.Isosceles)]
        public void IsIsosceles(ulong a, ulong b, ulong c, Core.Model.TriangleType type)
        {
            Assert.AreEqual(type, model.GetTriangleType(a, b, c));
            Assert.AreEqual(type, model.GetTriangleType(a, c, b));
            Assert.AreEqual(type, model.GetTriangleType(b, a, c));
            Assert.AreEqual(type, model.GetTriangleType(c, a, b));
            Assert.AreEqual(type, model.GetTriangleType(b, c, a));
            Assert.AreEqual(type, model.GetTriangleType(c, b, a));
        }

        [TestCase(2ul, 3ul, 4ul, Core.Model.TriangleType.Scalene)]
        [TestCase(42ul, 43ul, 44ul, Core.Model.TriangleType.Scalene)]
        [TestCase(SideHandler.MaxValue - 2, SideHandler.MaxValue - 1, SideHandler.MaxValue, Core.Model.TriangleType.Scalene)]
        public void IsScalene(ulong a, ulong b, ulong c, Core.Model.TriangleType type)
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


