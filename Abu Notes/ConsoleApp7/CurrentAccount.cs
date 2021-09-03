using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class CurrentAccount:BankAccount
    {
        private decimal overdrawCharge = 20.0m;
        //initialising variables using consrtuctors and calling the base class constructor
        public CurrentAccount(string fName, string lName, decimal initialBalance):base( fName, lName, initialBalance)
        {

        }
        //implementing overdrawal charges
        public override void Withdraw(decimal amount)
        {
            if(amount>balance)
            {
                amount += overdrawCharge;
            }
            base.Withdraw(amount);
           
        }
    }
}
