using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class BankAccount
    {
        protected string firstName;
        protected string lastName;
        public decimal balance;
        public BankAccount(string fName, string lName, decimal initialBalance)
        {
            this.firstName = fName;
            this.lastName = lName;
            this.balance = initialBalance;
        }
        public virtual void Deposit(decimal amount)
        {
            balance += amount;
            Console.WriteLine("Balance of {0} after Depositing is {1}",firstName, balance);
        }
        public virtual void Withdraw(decimal amount)
        {
            balance -= amount;
            Console.WriteLine("Balance of {0} after Withdrawal is {1}", firstName, balance);
        }
    }
}
