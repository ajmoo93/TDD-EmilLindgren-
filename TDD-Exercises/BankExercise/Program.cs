using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankExercise
{
   public class BankAccount
    {
        static void Main(string[] args)
        {
        }
        public decimal Balance { get; set; }
        public void Deposit(int amount)
        {
            Balance += amount;
        }
        public void Withdraw(int amount)
        {
            Balance -= amount;
        }
    }
}
