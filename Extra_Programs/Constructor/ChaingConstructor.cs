using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.Extra_Programs.Constructor
{
    class ChaingConstructor
    {
       

        ChaingConstructor() :this(10,20)
        {
            Console.WriteLine("Default constructor ");
        }
        ChaingConstructor(int a) 
        {
            Console.WriteLine("Paramertized Constructor ");
        }
        ChaingConstructor(int d ,int b) : this(10)
        {
            Console.WriteLine("i am Paramterized Constructor ");
        }
        static void Main(string[] args)
        {
            ChaingConstructor cc = new ChaingConstructor();


        }
    }
}
