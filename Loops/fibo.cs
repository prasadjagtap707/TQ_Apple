using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.Loops
{
    class fibo
    {
        static void Main(string[] args)
        {
            int n = 10;
            int a = 0, b = 1, c;
            if (n >= 0)
            {
                Console.Write(a+" ");
            }
            if (n >=1)
            {
                Console.Write(b+" ");
            }
            for (int i = 3; i <=n; i++)
            {
                c = a + b;
                Console.Write(c+" ");
                a = b;
                b = c;
            }
        }
    }
}
