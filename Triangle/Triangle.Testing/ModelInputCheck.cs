using System;
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
    class ModelInputCheck
    {
        private MainPresenter presenter = new MainPresenter(null);
        private readonly string[] stringArgs = { string.Empty, string.Empty, string.Empty };

        // spaces
        [TestCase("", "1", "1")]
        [TestCase("", "", "1")]
        [TestCase("", "", "")]
        // nulls
        [TestCase("0", "1", "1")]
        [TestCase("0", "0", "1")]
        [TestCase("0", "0", "0")]
        // out of bounds
        [TestCase("9223372036854775808", "9223372036854775808", "9223372036854775808")]
        [TestCase("9223372036854775808", "9223372036854775808", "100")]
        [TestCase("9223372036854775808", "100", "100")]
        public void CheckModelInput(string a, string b, string c)
        {
            Assert.Throws<ApplicationException>(() => presenter.GetTriangleType(a, b, c, stringArgs));
        }
    }
}

    