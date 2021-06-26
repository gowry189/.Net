using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface test
    {
        void messsage1();
    }
    public interface calculator : test
    {
        int add(int a, int b);
        int subs(int a, int b);
        int multi(int a, int b);
        int divs(int a, int b);
    }

    class calc1 : calculator
    {
        //all the methods declared in interface should be 
        //defined in the derived class
        public int add(int a, int b)
        {
            return a + b;
        }

        public int divs(int a, int b)
        {
            return a / b;
        }

        public int multi(int a, int b)
        {
            return a * b;
        }

        public int subs(int a, int b)
        {
            return a - b;
        }

        public void messsage1()
        {

        }
    }
    public interface bank_trans
        {
            void checkbalance();
        void sourceDeduct();
        void TargetAdd();

        }
    class bank : bank_trans
    {
        public void checkbalance()
        {
            throw new NotImplementedException();
        }

        public void sourceDeduct()
        {
            throw new NotImplementedException();
        }

        public void TargetAdd()
        {
            throw new NotImplementedException();
        }
    }


    class Class8
    {
        static void Main(string[] args)
        {
            calc1 c = new calc1();
            int z = c.add(10, 20);
            Console.Write(z);
        }
    }
}
