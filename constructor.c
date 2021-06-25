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
        }
    }
}
