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
    [TestFixture]
    class Existence
    {
        private MainPresenter presenter = new MainPresenter(null);
        private string[] stringArgs = new string[] { string.Empty, string.Empty, string.Empty };

        [TestCase("1", "2", "4")]
        [TestCase("1", "4", "2")]
        [TestCase("2", "1", "4")]
        [TestCase("4", "1", "2")]
        [TestCase("4", "2", "1")]
        [TestCase("1", "2", "4")]

        [TestCase("4", "21", "42")]
        [TestCase("4", "42", "21")]
        [TestCase("21", "4", "42")]
        [TestCase("42", "4", "21")]
        [TestCase("21", "42", "4")]
        [TestCase("42", "21", "4")]

        [TestCase("9223372036854775807", "10", "20")]
        [TestCase("9223372036854775807", "20", "10")]
        [TestCase("20", "9223372036854775807", "10")]
        [TestCase("10", "9223372036854775807", "20")]
        [TestCase("20", "10", "9223372036854775807")]
        [TestCase("10", "20", "9223372036854775807")]

        [TestCase("1", "2", "3")]
        [TestCase("1", "3", "2")]
        [TestCase("3", "1", "2")]
        [TestCase("2", "1", "3")]
        [TestCase("2", "3", "1")]
        [TestCase("3", "2", "1")]

        [TestCase("100", "200", "300")]
        [TestCase("100", "300", "200")]
        [TestCase("300", "100", "200")]
        [TestCase("200", "100", "300")]
        [TestCase("200", "300", "100")]
        [TestCase("300", "200", "100")]

        [TestCase("1", "100", "9223372036854775707")]
        [TestCase("1", "9223372036854775707", "100")]
        [TestCase("9223372036854775707", "1", "100")]
        [TestCase("100", "1", "9223372036854775707")]
        [TestCase("9223372036854775707", "100", "1")]
        [TestCase("100", "9223372036854775707", "1")]
        public void IsInvalid(string a, string b, string c)
        {
            Assert.Throws<ApplicationException>(() => presenter.GetTriangleType(a, b, c, stringArgs));
        }
    }
}
