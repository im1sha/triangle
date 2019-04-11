using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triangle.Core.Presenter;

namespace Triangle.Logic.Test
{
    [TestFixture]

    class InputChecks
    {
        private MainPresenter presenter = new MainPresenter(null);
        private InputParser parser = new InputParser();

        // alphabetical
        [TestCase("9223", 'e')]
        [TestCase("9223", 'н')]
        // signs
        [TestCase("9223", '-')]
        [TestCase("9223", '+')]
        // spec chars
        [TestCase("9223", '#')]
        [TestCase("9223", '@')]
        // delimiters
        [TestCase("9223", '.')]
        [TestCase("9223", ',')]
        // non-writable
        [TestCase("9223", (char)9)]
        public void ParserDeniedCharCheck(string str, char c)
        {
            Assert.AreEqual(parser.IsInputValid(str, c), false);
        }

        [TestCase("9223372036854775801", '0')]
        [TestCase("9223372036854775801", '9')]
        public void ParserTooLongStringCheck(string str, char c)
        {
            Assert.AreEqual(parser.IsInputValid(str, c), false);
        }

        [TestCase("9223", '0')]
        [TestCase("9223", '9')]
        [TestCase("9223", (char)8)]
        public void ParserAllowedCharCheck(string str, char c)
        {
            Assert.AreEqual(parser.IsInputValid(str, c), true);
        }

    }
}
