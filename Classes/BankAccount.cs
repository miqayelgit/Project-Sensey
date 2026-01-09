using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Sensey.Classes
{
    public class BankAccount
    {
        public int Balance { get; set; }

        public BankAccount(int amount)
        {
            Balance = amount;
        }

        public void Withdraw(int amount)
        {
            if (Balance == 0)
            {
                throw new Exception("Balance is 0!");
            }

            else if(amount > Balance)
            {
                throw new ArgumentException("Amount should be less than or equal to Balance");
            }

            Balance -= amount;
        }
    }
}
