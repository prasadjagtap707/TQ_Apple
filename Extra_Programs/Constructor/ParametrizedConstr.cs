using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.Extra_Programs.Constructor
{
    class ParametrizedConstr
    {
        int a, b;
        public ParametrizedConstr(int x,int y)
        {
            a = x;
            b = y;
        }
        static void Main(string[] args)
        {
            ParametrizedConstr pc = new ParametrizedConstr(10, 30);
            Console.WriteLine("A "+pc.a);
            Console.WriteLine("B "+pc.b);
        }
    }
}
