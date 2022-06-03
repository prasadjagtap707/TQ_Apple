using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.Oops
{

    class   P1
    {
      public virtual void m1()
        {
            Console.WriteLine("I Am M1 Method");
        }

        public virtual void m2()
        {
            Console.WriteLine("I am M2 Method");
        }
    }
    class C1:P1
    {
        public sealed override void m1()
        {
            Console.WriteLine("I am child M1 method");
        }
        override public void m2()
        {
            Console.WriteLine(" i  am child m2 method ");
        }
    }
    class C2 : C1
    {
        override public void m2()
        {
            Console.WriteLine(" I am class  C2 Child m2 method  ");
        }

    }
    class ParentSealed
    {
        static void Main(string[] args)
        {
            P1 p = new P1();
            p.m1();
            p.m2();

            P1 p2 = new C1();
            p2.m1();
            p2.m2();

            P1 p3 = new C2();
            p3.m1();
            p3.m2();

        }
       
    }


}
