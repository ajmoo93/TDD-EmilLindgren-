using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator.Test
{
    [TestFixture]
    public class StringCalculatorTests
    {
        private Calculator sut { get; set; }
        [SetUp]
        public void Setup()
        {
            sut = new Calculator();
        }

        [Test]
        public void ReturnZeroOrEmptystring()
        {
           var result = sut.Add("");
            Assert.AreEqual(0, result);
        }
        [Test]
        public void 
    }
}
