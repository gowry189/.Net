using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class emp_base
    {
        public int val1 = 10;
        //public void method1()
        //{
        //    Console.WriteLine("this is method1");
        //}

        //public void method2()
        //{
        //    Console.WriteLine("this is method2 value is {0}", val1);
        //}

        int empno, salary;
        string empname;
        public emp_base(int empno, string empname, int salary)
        {
            this.empno = empno;
            this.empname = empname;
            this.salary = salary;
        }
        public void print_p()
        {
            Console.WriteLine("employee no = {0} employee name = {1} employee = {2}",empno,empname, salary);

        } 
    }
    class emp_derive1: emp_base
    {
        int passport_num;
        string pass_type, place_issued, expiry_date;
        public emp_derive1(int p_num, string p_type, string p_issue, string e_date,int eno,string ename,int salary) :base(eno,ename,salary)
        {
            this.passport_num = p_num;
            this.pass_type = p_type;
            this.place_issued = p_issue;
            this.expiry_date = e_date;
        }
        public void print_p_values()
        {
            Console.WriteLine("Passport number = {0} passport type = {1} issue place = {2} expiry date = {3}", passport_num, pass_type, place_issued, expiry_date);
        }
    }
    //class emp_derive2 : emp_base
    //{
    //    int patient_no;
    //    string dr_name, disease;
    //    public emp_derive2(int patient_no, string dr_name, string disease, int p_num, string p_type, string p_issue, string e_date, int eno, string ename, int salary) : base(eno, ename, salary)
    //    {
    //        this.patient_no = p_num;
    //        this.dr_name = dr_name;
    //        this.disease = disease;
    //    }
    //    public void print_medical_values()
    //    {
    //        Console.WriteLine("Patient number = {0} Doctor name = {1} string disease = {2}", patient_no,dr_name,disease);
    //    }
    //}

    class Class4
    {
        static void Main(string[] args)
        {
            emp_derive2 emp = new emp_derive2(1,"sam", "fever",10012,"Diplomat", "Banglore","20/10/2016", 101,"sam",8000);
            emp.print_p();
            emp.print_p_values();
            emp.print_medical_values();

        }
    }
}
