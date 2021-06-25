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
     

        public void print(List<empdata1> emplst)
        {
           foreach(empdata1 c in emplst)
            { 
                Console.WriteLine("empno = {0} empname = {1} job = {2} salary = {3} ", c.empno, c.empname, c.job, c.salary);
            }
        }

        public void search(List<empdata1> emplst,int empno)
        {
            foreach (empdata1 c in emplst)
            {
                if (c.empno == empno)
                {
                    Console.WriteLine("empno = {0} empname = {1} job = {2} salary = {3} ", c.empno, c.empname, c.job, c.salary);
                }
            }
        }

    }


    class Class3
    {

        public static void print1()
        {
            Console.WriteLine("this s print1 method in default class");
        }

        static void Main(string[] args)
        {
            //int empno, salary;
            //string empname, job;
            empdata1[] objs = new empdata1[5];

            //objs[0] = new empdata1 { empno = 1001, empname = "sam", job = "manager", salary=5000 };
            //objs[1] = new empdata1 { empno = 1002, empname = "rahul", job = "dev", salary = 4000 };
            //objs[2] = new empdata1 { empno = 1003, empname = "sanjay", job = "dev", salary = 7000 };
            //objs[3] = new empdata1 { empno = 1004, empname = "rajiv", job = "Pm", salary = 8000 };
            //objs[4] = new empdata1 { empno = 1005, empname = "david", job = "dev", salary = 9000 };

            //empdata1 obj=null;

            //obj = new empdata1();
            //obj.empno = 1001;
            //obj.empname = "sam";
            //obj.job = "manager";
            //obj.salary = 8000;
            //objs[0] = obj;

            //obj = new empdata1();
            //obj.empno = 1002;
            //obj.empname = "rahul";
            //obj.job = "dev";
            //obj.salary = 9000;
            //objs[1] = obj;

            //obj = new empdata1();
            //obj.empno = 1003;
            //obj.empname = "rajiv";
            //obj.job = "dev";
            //obj.salary = 4000;
            //objs[2] = obj;

            //obj = new empdata1();
            //obj.empno = 1004;
            //obj.empname = "manish";
            //obj.job = "manager";
            //obj.salary = 9000;
            //objs[3] = obj;

            //obj = new empdata1();
            //obj.empno = 1005;
            //obj.empname = "david";
            //obj.job = "dev";
            //obj.salary = 7000;
            //objs[4] = obj;

           // Console.WriteLine("list array values");
           //List<int> ls = new List<int>();
           // ls.Add(100);
           // ls.Add(200);
           // ls.Add(300);
           // ls.Add(400);

           // List<string> ls1 = new List<string>();
           // ls1.Add("chennai");
           // ls1.Add("trivandrum");
           // ls1.Add("cochin");
           // ls1.Add("mumbai");

           // foreach(string str in ls1)
           // {
           //     Console.WriteLine(str);
           // }

           // for (int i=0;i<ls.Count;i++)
           // {
           //     Console.WriteLine(ls[i]);
           // }

            //List<empdata1> elist = new List<empdata1>();

            //elist.Add(new empdata1 { empno = 1001, empname = "sam", job = "dev", salary = 9000 });
            //elist.Add(new empdata1 { empno = 1002, empname = "rahul", job = "dev", salary = 4000 });
            //elist.Add(new empdata1 { empno = 1003, empname = "david", job = "dev", salary = 7000 });


            //foreach(empdata1 c in elist)
            //{
            //    Console.WriteLine("empno = {0} empname = {1} job = {2} salary = {3} ", c.empno,c.empname, c.job, c.salary);
            //}


            List<empdata1> emplst = new List<empdata1>();
            empdata1 obj = null;
            int i = 0;
            int choice = 0;
            do
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

                emplst.Add(obj);
               
                Console.WriteLine("press 1 to continue 0 to exit");
                choice = int.Parse(Console.ReadLine());
            }
            while(choice==1);

            Console.WriteLine("printing using index value");


            for (int j = 0; j < emplst.Count; j++)
            {
                Console.WriteLine("empno = {0} empname = {1} job = {2} salary = {3} ", emplst[j].empno, emplst[j].empname, emplst[j].job, emplst[j].salary);
            }

                //    Console.WriteLine("Enter empno");
                //    obj.empno = int.Parse(Console.ReadLine());

                //    Console.WriteLine("Enter empname");
                //    obj.empname = Console.ReadLine();

                //    Console.WriteLine("Enter job");
                //    obj.job = Console.ReadLine();

                //    Console.WriteLine("Enter salary");
                //    obj.salary = int.Parse(Console.ReadLine());

                //    objs[i] = obj;
                //    Console.WriteLine();
                //}



            emp3 obj1 = new emp3();
            obj1.print(emplst);

            Console.WriteLine("Enter empno to search");
            int empno = int.Parse(Console.ReadLine());
            obj1.search(emplst, empno);

            //Class3 c = new Class3();
            //c.print1();

            //print1();
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

        public void print(List<empdata1> emplst)
        {
           foreach(empdata1 c in emplst)
            { 
                Console.WriteLine("empno = {0} empname = {1} job = {2} salary = {3} ", c.empno, c.empname, c.job, c.salary);
            }
        }

        public void search(List<empdata1> emplst,int empno)
        {
            foreach (empdata1 c in emplst)
            {
                if (c.empno == empno)
                {
                    Console.WriteLine("empno = {0} empname = {1} job = {2} salary = {3} ", c.empno, c.empname, c.job, c.salary);
                }
            }
        }

        public int sum_sal(List<empdata1> emplst)
        {
            int sum = 0;
            foreach (empdata1 c in emplst)
            {
                sum = sum + c.salary;
            }
            return sum;
        }

    }


    class Class3
    {

        static void Main(string[] args)
        {
            List<empdata1> emplst = new List<empdata1>();
            empdata1 obj = null;
            int i = 0;
            int choice = 0;
            do
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

                emplst.Add(obj);
               
                Console.WriteLine("press 1 to continue 0 to exit");
                choice = int.Parse(Console.ReadLine());
            }
            while(choice==1);

         
            emp3 obj1 = new emp3();
            obj1.print(emplst);

            Console.WriteLine("Enter empno to search");
            int empno = int.Parse(Console.ReadLine());
            obj1.search(emplst, empno);
            Console.WriteLine("Sum of the salary");
            int sum=obj1.sum_sal(emplst);
            Console.WriteLine(sum);

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

    class con_class
    {
        int empno, sal;
        string empname;


        public con_class()
        {
            this.empno = 1000;
            this.empname = "manish";
            this.sal = 8900;
        }

        public con_class(int empno)
        {
            this.empno =empno;
            this.empname = "david";
            this.sal = 9700;
        }
        public con_class(con_class obj)
        {
            this.empno = obj.empno;
            this.empname = obj.empname;
            this.sal = obj.sal;
        }

        public con_class(string empname)
        {
            this.empno = 1001;
            this.empname = empname;
            this.sal = 9700;
        }
        public con_class(int empno,string empname,int sal)
        {
            this.empno = empno;
            this.empname = empname;
            this.sal = sal;
        }

        public void printValues()
        {
            Console.WriteLine("empno {0} empname = {1} salary = {2}", empno, empname, sal);
        }
    }

    class Class4
    {
        static void Main(string[] args)
        {
            
            con_class con = new con_class(101,"sam",8000);
            con.printValues();

            con_class con2 = new con_class();
            con2.printValues();

            con_class con3 = new con_class(1001);
            con3.printValues();

            con_class con4 = new con_class("rajiv");
            con4.printValues();

            con_class con5 = new con_class(con3);
            con5.printValues();

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

    class emp_base
    {
        int empno, salary;
        string empname;

        public emp_base(int empno, string empname, int salary)
        {
            this.empno = empno;
            this.empname = empname;
            this.salary = salary;
        }

        public void printValues()
        {
            Console.WriteLine("empno {0} empname = {1} salary = {2}", empno, empname, salary);
        }
    }

    class emp_derive1:emp_base
    {
        int p_num;
        string p_type, p_issue, e_date;
        public emp_derive1(int p_num, string p_type, string p_issue,string e_date,int eno,string ename,int sal):base(eno,ename,sal)
        {
            this.p_num =p_num;
            this.p_type = p_type;
            this.p_issue = p_issue;
            this.e_date = e_date;
        }

        public void print_p_Values()
        {
            Console.WriteLine("pnum {0} p_type = {1} p_issue = {2} e_date = {3}", p_num, p_type, p_issue,e_date);
        }

    }

    //class emp_derive2 : emp_derive1
    //{
    //    public void method5()
    //    {
    //        Console.WriteLine("this is method5");
    //    }
    //    public void method6()
    //    {
    //        Console.WriteLine("this is method6 val = {0}", val1);
    //    }
    //}

    class Class5
    {
        static void Main(string[] args)
        {

            emp_derive1 emp = new emp_derive1(10012, "diplomat", "bangalore", "20/10/2026",1001,"sam",4000);
            emp.printValues();
            emp.print_p_Values();
          
           
        }
    }
}





 
