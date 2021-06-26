using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class des_poly
    {
        public void Search(int empno)
        {
            Console.WriteLine("Search by empno {0}", empno);
        }
        public void Search(string job)
        {
            //connectig a database and retrice a record
            Console.WriteLine("search by job {0}", job);
        }
        public void Search(string job, int deptno)
        {
            //connectig a database and retrice a record
            Console.WriteLine("search by job and deptno {0}", deptno);
        }
        public void Search(int deptno, string location)
        {
            //connectig a database and retrice a record
            Console.WriteLine("search by deptno and location {0}", location);
        }
    }
    class Class6
    {
        static void Main(string[] args)
        {
            des_poly d = new des_poly();
            int choice = 0;
            do
                {
                    Console.WriteLine("--Employee Search--");
                    Console.WriteLine("1.SearchByEmpno");
                    Console.WriteLine("2.SearchByJob");
                    Console.WriteLine("3.SearchByJob and Deptno");
                    Console.WriteLine("4.SearchByDeptno and Location");
                    Console.WriteLine("Press any Key to Search.......");
                    int key = Convert.ToInt32(Console.ReadLine());



                    if (key == 1)
                    {
                        Console.WriteLine("enter the empno to search");
                        int empno = Convert.ToInt32(Console.ReadLine());
                        d.Search(empno);
                    }



                    else if (key == 2)
                    {
                        Console.WriteLine("enter the job to search");
                        string job = Console.ReadLine();
                        d.Search(job);
                    }



                    else if (key == 3)
                    {
                        Console.WriteLine("enter the job ");
                        string job = Console.ReadLine();
                        Console.WriteLine("enter the deptno");
                        int deptno = Convert.ToInt32(Console.ReadLine());
                        d.Search(job, deptno);
                    }



                    else if (key == 4)
                    {



                        Console.WriteLine("enter the deptno");
                        int deptno = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter the location ");
                        string location = Console.ReadLine();
                        d.Search(deptno, location);
                    }
                    Console.WriteLine("press 1 to continue 0 to exit");
                    choice = Convert.ToInt32(Console.ReadLine());



                }
                while (choice == 1);
        }
    }
}
