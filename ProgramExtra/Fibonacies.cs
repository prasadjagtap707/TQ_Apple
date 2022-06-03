using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.ProgramExtra
{
    class Fibonacies
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 1, n3, i;
            for (i = 2; i < 10; ++i)
            {
                
                    n3 = n1 + n2;
                    Console.Write(n3 + " ");
                    n1 = n2;
                    n2 = n3;
                
            }
        }
    }
}
