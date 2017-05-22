using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationEngine.Test
{
    class ValidationTest
    {
        [Test]
        public void TrueForValidAddress()
        {
            var sut = new EmailValidator();

            var istrue = sut.ValidateEmailAddress("exe@mail.com");

            Assert.IsTrue(istrue);

        }
    }
}
