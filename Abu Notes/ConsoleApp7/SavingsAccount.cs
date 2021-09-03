using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class SavingsAccount:BankAccount
    {
        decimal interestRate = 0.0m;
        decimal withdrawCharge = 20.0m;
        int withdrawLimit = 3;
        int withdrawCount = 0;
       public SavingsAccount(string fName, string lName,decimal interest, decimal initialBalance):base(fName, lName, initialBalance)
        {
            this.interestRate = interest;
        }
        //applying interest and depositing the calculated amount
        public void ApplyInterest()
        {
            decimal interestAmount = (balance * (interestRate / 100));
            base.Deposit(interestAmount);

        }
        //calculating withdrawal count and applying withdrawal charges if the limit is exceeded
        public override void Withdraw(decimal amount)
        {
            if (amount > balance)
            {
                Console.WriteLine("Enough balance not available");
            }
            else
            {
                base.Withdraw(amount);
                withdrawCount++;
                if(withdrawCount>withdrawLimit)
                {
                    Console.WriteLine("Withdraw limit exceed - addictional charges will be applied");
                    base.Withdraw(withdrawCharge);
                }

                
            }
        }
    }
}
