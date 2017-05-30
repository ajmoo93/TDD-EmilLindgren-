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
        [TestCase(1,"1")]
        [TestCase(2,"2")]
        public void ReturnNumberIfGivenNumber(int expected, string input)
        {
            var result = sut.Add("1");

            Assert.AreEqual(1, result);
           // Assert.That(sut.Add(input), Is.EqualTo(expected));
        }
        [Test]
        [TestCase(3, "1,2")]
        [TestCase(6, "1,2,3")]
        public void NumbersDelimitedByComma(int expected, string input)
        {
            var result = sut.Add(input);
            Assert.AreEqual(expected, result);
        }
        [Test]
        [TestCase(3,"1\n2")]

        [TestCase(6, "//;\n1;2,\n3")]
        [TestCase(3, "//;\n1;2;")]
        public void ShouldBeComatiblewithDifferentParameters(int expected, string input)
        {
            var result = sut.Add(input);
            Assert.AreEqual(expected, result);
        }
        [Test]
        [TestCase(8, "//;\n1;\n2\n3-2")]
        public void ShouldNotBeAllowerToSendInMinus(int expected, string input)
        {
            var result = sut.Add(input);
            Assert.AreEqual(expected, result);
        }
    }
}
