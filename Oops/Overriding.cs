using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.Oops
{
    class Overriding
    {
        void m1()
        {
            Console.WriteLine("Hello i am ");
        }
        void m1(int a)
        {
            Console.WriteLine(  "Interger ");
        }
        static void Main(string[] args)
        {
            Overriding or = new Overriding();
            or.m1();
        }
    }
}
