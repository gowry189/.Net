using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class con_class
    {
        int empno, sal;
        string empname;
        public con_class()
        {
            empno = 1001;
            empname = "sam";
            sal = 8000;
        }
        public con_class(int empno)
        {
            this.empno = empno;
            empname = "sam";
            sal = 8000;
        }
        public con_class(con_class obj)
        {
            this.empno = obj.empno;
            this.empname = obj.empname;
            this.sal = obj.sal;
        }

        public con_class(string empname)
        {
            this.empno = 104;
            this.empname = empname;
           this.sal = 8000;
        }
        public con_class(int empno, string empname, int sal)
        {
            this.empno = empno;
            this.empname = empname;
            this.sal = sal;
        }

        public void printValues()
        {
            Console.WriteLine("empno = {0} empname = {1} salary = {2}", empno,empname,sal);
        }
    }
    class Class3
    {
        static void Main(string[] args)
        {
            con_class con = new con_class();
            con.printValues();
            con_class con1 = new con_class(101,"Gowry",5000);
            con1.printValues();
            con_class con2 = new con_class(102);
            con2.printValues();
            con_class con3 = new con_class("Akshay");
            con3.printValues();
            con_class con4 = new con_class(con2);
            con4.printValues();
        }
    }
}
