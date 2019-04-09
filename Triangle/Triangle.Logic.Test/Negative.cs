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
    class Negative
    {
        private MainPresenter presenter = new MainPresenter(null);
        private string[] stringArgs = new string[] { string.Empty, string.Empty, string.Empty };


        [TestCase("", "1", "1")]
        public void IsInvalid(string a, string b, string c)
        {
            Assert.Throws<ApplicationException>(() => presenter.GetTriangleType(a, b, c, stringArgs));
        }
    }
}

    
//1


//1
//1

//0
//1
//1
//0
//0
//1
//0
//9223372036854775808
//9223372036854775808
//100
//9223372036854775808
//100
//9223372036854775808
//100