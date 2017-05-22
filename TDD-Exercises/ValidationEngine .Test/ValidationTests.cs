using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationEngine.Test
{
    public class ValidationTests
    {
        [Test]
        public void trueforvalidaddress()
        {
            var sut = new EmailValidator();

            var istrue = sut.ValidateEmailAddress("exe@mail.com");

            Assert.IsTrue(istrue);


        }
        [Test]
        public void FalseForValidAddress()
        {
            var sut = new EmailValidator();

           
            var IsFalse = sut.ValidateEmailAddress("not@excom");
            
            Assert.IsFalse(IsFalse, sut.Email);

        }
        [Test]
        public void NullForValidAddress()
        {
            var sut = new EmailValidator();


            var IsNull = sut.ValidateEmailAddress("");

            Assert.IsFalse(IsNull);

        }
    }
}
