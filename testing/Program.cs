using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing
{
    interface Isome
    {
         int testprop { get; set; }
        void Isomethin();
    }
    class parent:Isome
    {
        public int testprop
        {
            get
            {
                //throw new NotImplementedException();
                return 0;
            }

            set
            {
                //throw new NotImplementedException();
            }
        }

        public void Isomethin()
        {
            Console.WriteLine("parent interface");
        }
        public virtual void m1()
        {
            Console.WriteLine("parent");
        }
    }
    class child : parent, Isome
    {
        public void  Isomethin()
        {
            Console.WriteLine("child interface");
        }

        //public child()
        //{
        //    base.m1();
        //}

        public override void m1()
        {
            Console.WriteLine("child");
        }

        public void m1(double a, float b)
        {
            Console.WriteLine("int float");
        }
        public void m1(float a, int b)
        {
            Console.WriteLine("float int");
        }
        public void m2()
        {

            Console.WriteLine("child");
            base.m1();
        }

        //public new void m1()
        //{
        //    Console.WriteLine("child");
        //}
    }
    class sister : child, Isome
    {
        public  void Isomethin()
        {
            Console.WriteLine("sister implemnted interface");
            //throw new NotImplementedException();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // parent p = new child();
            //  c.m2();
            //c.m1(10.2f,11);
            // p.m1();

            parent s = new sister();
            s.Isomethin();
            

            Console.ReadLine();
        }
    }
}
