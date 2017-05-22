using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankExercise.Test
{
    public class BankTest
    {
        //[Test]
        //public void StartWithXero()
        //{
        //    var sut = new BankExercise();
        //    Assert.AreEqual(1000, sut.Balance)


        //}
        [Test]
        public void BnkDeposit()
        {
            var sut = new BankAccount();

            sut.Deposit(1000);
            Assert.AreEqual(1000, sut.Balance);
        }

        public void CanWithdrawMoney()
        {
            var sut = new BankAccount();
            sut.Withdraw(1000);
            Assert.AreEqual(-1000, sut.Balance, "Can withdraw money");
        }
    }
}
