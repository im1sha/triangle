using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triangle.Core.Model;
using Triangle.Core.Presenter;

namespace Triangle.Logic.Testing
{
    [TestFixture]
    class ExistenceCheck
    {
        private readonly MainPresenter presenter = new MainPresenter(null);
        private readonly string[] stringArgs = new string[] { string.Empty, string.Empty, string.Empty };

        // third side is grater than first one + second one 
        [TestCase("1", "2", "4")]
        [TestCase("4", "21", "42")]
        [TestCase("9223372036854775807", "10", "20")]

        // third side equals to first one + second one 
        [TestCase("1", "2", "3")]
        [TestCase("100", "200", "300")]
        [TestCase("1", "100", "9223372036854775707")]

        public void IsInvalid(string a, string b, string c)
        {
            Assert.Throws<ApplicationException>(() => presenter.GetTriangleType(a, b, c, stringArgs));
            Assert.Throws<ApplicationException>(() => presenter.GetTriangleType(a, c, b, stringArgs));
            Assert.Throws<ApplicationException>(() => presenter.GetTriangleType(b, a, c, stringArgs));
            Assert.Throws<ApplicationException>(() => presenter.GetTriangleType(c, a, b, stringArgs));
            Assert.Throws<ApplicationException>(() => presenter.GetTriangleType(b, c, a, stringArgs));
            Assert.Throws<ApplicationException>(() => presenter.GetTriangleType(c, b, a, stringArgs));
        }

        // third side is grater than first one + second one 
        [TestCase("1", "1", "1")]
        [TestCase("1", "2", "2")]
        [TestCase("4", "3", "2")]
        [TestCase("9223372036854775707", "9223372036854775707", "9223372036854775707")]
        [TestCase("9223372036854775707", "9223372036854775707", "9223372036854775706")]
        [TestCase("9223372036854775707", "9223372036854775706", "9223372036854775705")]
        public void IsValid(string a, string b, string c)
        {
            Assert.DoesNotThrow(() => presenter.GetTriangleType(b, a, c, stringArgs));
            Assert.DoesNotThrow(() => presenter.GetTriangleType(b, c, a, stringArgs));
            Assert.DoesNotThrow(() => presenter.GetTriangleType(a, b, c, stringArgs));
            Assert.DoesNotThrow(() => presenter.GetTriangleType(c, b, a, stringArgs));
            Assert.DoesNotThrow(() => presenter.GetTriangleType(a, c, b, stringArgs));
            Assert.DoesNotThrow(() => presenter.GetTriangleType(c, a, b, stringArgs));
        }
    }
}
