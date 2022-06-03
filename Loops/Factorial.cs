using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.Loops
{
    class Factorial
    {
        static void Main(string[] args)
        {
            int f = 1, Sum = 0;
            int N = 5;

            for (int i = 1; i <= N; i++)
            {

                f = f * i;
                Sum += f;
            }

            Console.WriteLine(  Sum);
        }
    }
}
