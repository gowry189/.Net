//24-06-2021
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{

    class empdata
    {
        public int empno { get; set; }
        public string empname { get; set; }
        public string job { get; set; }
        public int salary { get; set; }
    }


    class employee
    {
        empdata obj = new empdata();
        int pf, tax, netsal;
        public void Read_Emp_Info()
        {
            Console.WriteLine("Enter empno");
            obj.empno = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter empname");
            obj.empname = Console.ReadLine();

            Console.WriteLine("Enter job");
            obj.job = Console.ReadLine();

            Console.WriteLine("Enter salary");
            obj.salary = int.Parse(Console.ReadLine());
        }
        public void Cal_Netsal()
        {
            if (obj.salary >= 15000 && obj.salary < 20000)
            {
                tax = obj.salary * 12 / 100;
            }
            else if (obj.salary >= 10000 && obj.salary < 15000)
            {
                tax = obj.salary * 10 / 100;
            }
            else if (obj.salary >= 8000 && obj.salary < 10000)
            {
                tax = obj.salary * 8 / 100;
            }
            else
            {
                tax = obj.salary * 6 / 100;
            }

            pf = obj.salary * 2 / 100;
            netsal = obj.salary - (tax + pf);
        }

        public void Print()
        {
            Console.WriteLine("empno = {0} empname = {1} job = {2} salary = {3} netalary = {4}", obj.empno, obj.empname, obj.job, obj.salary, netsal);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            employee obj = new employee();

            obj.Read_Emp_Info();
            obj.Cal_Netsal();
            obj.Print();


            //int[] num = new int[10];
            //string[] city = new string[5];

            //num[0] = 100;
            //num[1] = 200;
            //num[2] = 300;
            //num[3] = 100;
            //num[4] = 200;
            //num[5] = 500;
            //num[6] = 800;
            //num[7] = 200;
            //num[8] = 300;
            //num[9] = 900;

            //Console.WriteLine("read array");

            //for (int i = 0; i < num.Length; i++)
            //{
            //    num[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("print array");

            //for (int i=0;i<num.Length;i++)
            //{
            //    Console.WriteLine(num[i]);
            //}

            
            //city[0] = "bangalore";
            //city[1] = "chennai";
            //city[2] = "delhi";
            //city[3] = "trivandrum";
            //city[4] = "mumbai";


            //for(int i=0;i<city.Length;i++)
            //{
            //    Console.WriteLine("enter city name");
            //    city[i] = Console.ReadLine();
            //}
            //Console.WriteLine("city names");
            //for (int i = 0; i < city.Length; i++)
            //{
            //    Console.WriteLine(city[i]);
            //}

          


            Console.Read();

            //int empno, salary, pf, tax, netsal;
            //string empname, job;

            //Console.WriteLine("Enter empno");
            //empno = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter empname");
            //empname = Console.ReadLine();

            //Console.WriteLine("Enter job");
            //job = Console.ReadLine();

            //Console.WriteLine("Enter salary");
            //salary = int.Parse(Console.ReadLine());



            //if (salary >= 15000 && salary < 20000)
            //{
            //    tax = salary * 12 / 100;
            //}
            //else if (salary >= 10000 && salary < 15000)
            //{
            //    tax = salary * 10 / 100;
            //}
            //else if (salary >= 8000 && salary < 10000)
            //{
            //    tax = salary * 8 / 100;
            //}
            //else
            //{
            //    tax = salary * 6 / 100;
            //}

            //pf = salary * 2 / 100;
            //netsal = salary - (tax + pf);


            //Console.WriteLine("empno = {0} empname = {1} job = {2} salary = {3} netalary = {4}", empno, empname, job, salary, netsal);

        }
    }
}





using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public struct emp1
    {
        public int empno;
        public string empname;
        public int salary;
    }

    //getter/setter class
    //model class
    //Entity Class
    class emp2
    {
        public int empno { get; set; }
        public string empname { get; set; }
        public int salary { get; set; }
    }

    class product
    {
        public int p_id { get; set; }
        public string p_name { get; set; }
        public int price{ get; set; }
    }

    class Class1
    {
        static void Main(string[] args)
        {

            product p = new product();
            p.p_id = 101;
            p.p_name = "Laptop";
            p.price = 7800;

            Console.WriteLine("Product details");
            Console.WriteLine("p_id = {0}  p_name = {1} price = {2}", p.p_id, p.p_name, p.price);


            emp2 eobj = new emp2();
            eobj.empno = 1001;
            eobj.empname = "rahul";
            eobj.salary = 9000;

            Console.WriteLine("Using Class Object");
            Console.WriteLine("empno = {0}  empname = {1} salary = {2}", eobj.empno, eobj.empname, eobj.salary);


            emp1 obj;
            obj.empno = 1001;
            obj.empname = "sam";
            obj.salary = 6000;

            Console.WriteLine("Using Structure");
            Console.WriteLine("empno = {0}  empname = {1} salary = {2}", obj.empno, obj.empname, obj.salary);
          

        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class empdata1
    {
        public int empno { get; set; }
        public string empname { get; set; }
        public string job { get; set; }
        public int salary { get; set; }
    }
    class emp3
    {
        //public void print(int empno,string empname,string job,int salary)
        //{
        //    Console.WriteLine("empno = {0} empname = {1} job = {2} salary = {3} ", empno,empname,job, salary);
        //}
        public void print(empdata1 obj)
        {
            Console.WriteLine("empno = {0} empname = {1} job = {2} salary = {3} ", obj.empno, obj.empname, obj.job, obj.salary);
        }
    }

    class Class3
    {
        static void Main(string[] args)
        {
            //int empno, salary;
            //string empname, job;
            empdata1 obj = new empdata1();

            Console.WriteLine("Enter empno");
            obj.empno = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter empname");
            obj.empname = Console.ReadLine();

            Console.WriteLine("Enter job");
            obj.job = Console.ReadLine();

            Console.WriteLine("Enter salary");
            obj.salary = int.Parse(Console.ReadLine());

            emp3 obj1 = new emp3();
            //obj1.print(empno, empname, job, salary);
            obj1.print(obj);
        }
    }
}

//25-06-2021
//create object array
empdata1 obj = null;

            for (int i = 0; i < objs.Length; i++)
            {
                obj = new empdata1();

                Console.WriteLine("Enter empno");
                obj.empno = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter empname");
                obj.empname = Console.ReadLine();

                Console.WriteLine("Enter job");
                obj.job = Console.ReadLine();

                Console.WriteLine("Enter salary");
                obj.salary = int.Parse(Console.ReadLine());

                objs[i] = obj;
                Console.WriteLine();
            }
