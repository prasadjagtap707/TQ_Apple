using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.Loops
{
    class PrimeNumber
    {
        static void Main(string[] args)
        {
            int count = 0, n = 300, i = 1, j = 1;
            while (n < 400)
            {
                j = 1;
                count = 0;
                while (j <= i)
                {
                    if (i % j == 0)
                        count++;
                    j++;
                }
                if (count == 2)
                {
                    Console.Write(i);
                    Console.Write(" ");
                    n++;
                }
                i++;
            }
         
        }
    }
}
