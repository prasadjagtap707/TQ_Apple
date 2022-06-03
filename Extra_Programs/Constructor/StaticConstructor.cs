using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.Extra_Programs.Constructor
{
    class StaticConstructor
    {
        int a = 10;
        static StaticConstructor()
        {
            Console.WriteLine("Hello I am static Constructor");
        }
        static void Main(string[] args)
        {
            //StaticConstructor sc = new StaticConstructor();
        }
    }
}
