using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.Methods
{

  public  class A
    {
        private protected int x;
        protected internal int y;
        internal void m1()
        {
            Console.WriteLine("A class method m1 ");
        }

        internal virtual void m2()
        {
            Console.WriteLine(" A Method M2");
        }

        static internal void m3()
        {
            Console.WriteLine(" A class static method m3");
        }
        /*
       // static virtual internal void m4()
        {
            Console.WriteLine( "A class Static method m4");
        }


      //  sealed internal void m5()
        {
            Console.WriteLine("Sealed method keyword using m5 method ");
        }

    //    sealed static internal void m6()
        {
            Console.WriteLine();
        }*/

        private protected void m7()
        {
            Console.WriteLine(" Mehtod Private Protected Method using ");
        }
        
    }
    class StaticUsingSealed
    {
        static void Main(string[] args)
        {
         //   A o = new A();
          //  A.m1();
        }
    }
}
