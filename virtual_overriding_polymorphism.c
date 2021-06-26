using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class emp_class1
    {
        public void readInfo()
        {
            Console.WriteLine("reading: empno,empname,email,pone,location,bg,age,passno");
        }
        public void printInfo()
        {
            Console.WriteLine("printing: empno,empname,email,pone,location,bg,age,passno");
        }
        public virtual void cal_monthly_pay()
        {
            Console.WriteLine("cal: monthlypay = salary-tax(3)-pf(4)+ta(5)+sa($500)");
        }
    }
    class emp_class1_subs : emp_class1
    {
        public override void cal_monthly_pay()
        {
            Console.WriteLine("cal: monthlypay = salary-tax(6)-pf(7)+ta(5)+p_allowance(2)+sa($500)");
        }
        public void test()
        {
            Console.WriteLine("this is test");

        }
    }
    class emp_class1_subs1 : emp_class1
    {
        public override void cal_monthly_pay()
        {
            Console.WriteLine("cal : monthlypay = salary-tax(6)+sa($500)");
        }

    }
    class Class7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("employee details");
            Console.WriteLine("1.version");
            Console.WriteLine("2.version");
            Console.WriteLine("3.version");
            Console.WriteLine("Press any key....");
           
            int key = Convert.ToInt32(Console.ReadLine());
            emp_class1 obj;
            if (key == 1)
            {
                obj = new emp_class1();
                Console.WriteLine("base");
                obj.readInfo();
                obj.printInfo();
                obj.cal_monthly_pay();
            }
            else if (key == 2)
            {
                obj = new emp_class1_subs();
                Console.WriteLine("overridden version 1");
                obj.readInfo();
                obj.printInfo();
                obj.cal_monthly_pay();
                //we will not be able to call test
            }
            else if (key == 3)
            {
                obj = new emp_class1_subs1();
                Console.WriteLine("overridden version 2");
                obj.readInfo();
                obj.printInfo();
                obj.cal_monthly_pay();
                //we will not be able to call test
            }
        }
    }
}
