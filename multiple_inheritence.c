using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   
    class emp
    {
      public void read()
        {
            Console.WriteLine("reading/empno/empname/address/phone");
        }
       public void print()
        {
            Console.WriteLine("printing/empno/empname/address/phone");
        }
    }
    class reg_employee : emp
    {
        public void read1()
        {
            base.read();
            Console.WriteLine("reading/salary/tax/ta/sa");
        }
        public void cal_pay()
        {
            Console.WriteLine("calculate netpay(salary,tax,ta,sa)");
        }
        public void print1()
        {
            base.print();
            Console.WriteLine("printing/salary/tax/ta/sa/netpay");
        }
    }
    class con_employee : emp
    {
        public void read1()
        {
            base.read();
            Console.WriteLine("reading/cont_period/cont-amount/GST");
        }
        public void cal_pay()
        {
            Console.WriteLine("calculate netpay(cont_period/cont-amount/GST)");
        }
        public void print1()
        {
            base.print();
            Console.WriteLine("printing/cont_period/cont-amount/GST/netpay");
        }
    }
    class free_employee : emp
    {
        public void read1()
        {
            base.read();
            Console.WriteLine("reading/weeklypay/tds/free_allowance");
        }
        public void cal_pay()
        {
            Console.WriteLine("calculate netpay(weeklypay/tds/free_allowance)");
        }
        public void print1()
        {
            base.print();
            Console.WriteLine("printing/weeklypay/tds/free_allowance/netpay");
        }

    }
    class Class5
    {
        static void Main(string[] args)
        {
            int choice = 0;
            do
            {
                Console.WriteLine("Employee Management");
                Console.WriteLine("1-regular employee");
                Console.WriteLine("2-contract employee");
                Console.WriteLine("3-freelance employee");
                Console.WriteLine("4-others");
                Console.WriteLine("press any key.........");
                int key = Convert.ToInt32(Console.ReadLine());
                if (key == 1)
                {
                    reg_employee obj = new reg_employee();
                    obj.read1();
                    obj.cal_pay();
                    obj.print1();
                }
                else if (key == 2)
                {
                    con_employee obj = new con_employee();
                    obj.read1();
                    obj.cal_pay();
                    obj.print1();
                }
                else if (key == 3)
                {
                    free_employee obj = new free_employee();
                    obj.read1();
                    obj.cal_pay();
                    obj.print1();
                }
                Console.WriteLine("Press 1 to continue 0 to exit");
                choice = Convert.ToInt32(Console.ReadLine());            }
            while (choice == 1);
        }
    }
}
