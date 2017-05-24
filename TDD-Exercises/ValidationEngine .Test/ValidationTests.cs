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
        public void SendingInTrueforvalidation_ReturnsTrue()
        {
            var sut = new EmailValidator();

            var istrue = sut.ValidateEmailAddress("exe@mail.com");

            Assert.IsTrue(istrue);


        }
        [Test]
        public void SendingInFalseforvalidation_ReturnsFalse()
        {
            var sut = new EmailValidator();

           
            var IsFalse = sut.ValidateEmailAddress("not@excom");
            
            Assert.IsFalse(IsFalse);

        }
        [Test]
        public void SendingInNullForValidation_ReturnsFalse()
        {
            var sut = new EmailValidator();


            var IsFalseIfNull = sut.ValidateEmailAddress("");

            Assert.IsFalse(IsFalseIfNull);

        }
    }
}
