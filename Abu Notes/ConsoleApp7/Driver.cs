using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Driver
    {
        static  void   Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter the First name");
                string fName = Console.ReadLine();
                Console.WriteLine("Enter the Last name");
                string lName = Console.ReadLine();

                Console.WriteLine("Enter 1 for current 2 for savings");
                int c = int.Parse(Console.ReadLine());

                if (c == 2)
                {


                    //creating current account instance
                    CurrentAccount current = new CurrentAccount(fName, lName, 0);
                    current.Deposit(10000.0m);
                    current.Withdraw(200.0m);
                }

                else if (c == 1)
                {

                    //creating savings account instance
                    SavingsAccount saving = new SavingsAccount(fName, lName, 25, 0);
                    saving.Deposit(5000.0m);
                    saving.Withdraw(100.0m);
                    saving.ApplyInterest();
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
                Console.WriteLine("Do you wwant to continue y/n");
                string choice = Console.ReadLine();
                if (choice == "n")
                {
                    return;
                }
            }
           
            
        }   
        

    }
}
