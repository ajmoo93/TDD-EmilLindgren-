using Extra_Exercise_3;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSubstitute;
using Nsubstututeing;

namespace Nsubstituting.Test
{
    [TestFixture]
    public class Nsubstitutetests
    {
        private Bank sut;
        private Account account, account2, account3;
        
        // Sparar vi in Iaudiologger til len veriabel
        private IAuditLogger audiologgerMock;
        [SetUp]
        public void Setup()
        {
            //Mockar upp en ny Iaudiolog
            audiologgerMock = Substitute.For<IAuditLogger>();
            sut = new Bank(audiologgerMock);
            account = new Account { Name = "Wild", Number = "5458545", Balance = 0 };
            account2 = new Account { Name = "somi", Number = "4458545", Balance = 0 };
            account3 = new Account { Name = "somi", Number = "hej", Balance = 0 };
            


        }
        [Test]
        public void CanCreateBankAccount()
        {
            sut.CreateAccount(account);
            var result = sut.GetAccount(account.Number);
            Assert.AreEqual("Wild", result.Name);
            Assert.AreEqual("5458545", result.Number);
            Assert.AreEqual(0, result.Balance);
        }
        [Test]
        public void CanNotCreateDuplicateAccounts()
        {
            sut.CreateAccount(account);
            //Dessa här behövs inte för då gjör du dubbelt jobb, så dessa skall bort
            //var result = sut.GetAccount(account.Number);
            //Assert.AreEqual("5458545", result.Number);

            Assert.Throws<DuplicateAccount>(() => sut.CreateAccount(account));

        }
        [Test]
        public void WhenCreatingAnAccount_AMessageIsWrittenToTheAuditLog()
        {

            sut.CreateAccount(account);
            //Retunerar en lista av audiloggs
            sut.GetAuditLog();
            //Add messege blir anripat på din mock med ett medelande som inehåller namn och nummer.
            //Is gör så att tex till x blir en sträng, kollar då om objected är en sträng
            audiologgerMock.Received().AddMessage(Arg.Is<string>(x => x.Contains(account.Number) && x.Contains(account.Name)));
            
        }
        [Test]
        public void WhenCreatingAnValidAccount_OneMessageAreWrittenToTheAuditLog()
        {
            sut.CreateAccount(account);
            sut.GetAuditLog();
            //här skall vi göra så den anropar 1 gång och den bryr sig int
            //om någon account information.
            //Any betyder att den inehåller vad som med string
            audiologgerMock.Received(1).AddMessage(Arg.Any<string>());

        }
        [Test]
        public void WhenCreatingAnInvalidAccount_TwoMessagesAreWrittenToTheAuditLog()
        {
            sut.CreateAccount(account);
            sut.CreateAccount(account2);
            sut.GetAuditLog();
            audiologgerMock.Received(2).AddMessage(Arg.Any<string>());

        }
        [Test]
        public void WhenCreatingAnInvalidAccount_AWarn12AndErro45MessageIsWrittenToAuditLog()
        {
            
           
            Assert.Throws<InvalidAccount>(() => sut.CreateAccount(account3));
            audiologgerMock.Received(2).AddMessage(Arg.Is<string>(x => x.Contains("Warn12:") || x.Contains("Error45:")));
            

        }
        [Test]
        public void VerifyThat_GetAuditLog_GetsTheLogFromTheAuditLogger()
        {
            //skallbestämma vad suditlogger skall returnera
            audiologgerMock.GetLog().Returns(new List<string> { "då", "hej" });
            var result = sut.GetAuditLog();
            Assert.AreEqual("då", result[0]);
            Assert.AreEqual("hej", result[1]);

        }
    }
}
