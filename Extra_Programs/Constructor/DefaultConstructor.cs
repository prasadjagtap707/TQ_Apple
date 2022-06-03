using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.Extra_Programs.Constructor
{
    class DefaultConstructor
    {
        int a, b;
       public DefaultConstructor()
        {
            a = 10;
            b = 20;
        }
        static void Main(string[] args)
        {
            DefaultConstructor dc = new DefaultConstructor();
            Console.WriteLine("A "+dc.a);
            Console.WriteLine("B "+dc.b);
            Console.WriteLine();
        }
    }
}
