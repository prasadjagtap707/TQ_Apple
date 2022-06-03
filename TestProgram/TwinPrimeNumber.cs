using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.TestProgram
{
    class TwinPrimeNumber
    {
        static void Main(string[] args)
        {
            int n1, n2, c1 = 0, c2 = 0, d;


            Console.WriteLine("Enter First number:");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second number:");
            n2 = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n1; i++)
            {
                if (i % n1 == 0)
                    c1++;

            }
            for (int i = 1; i <= n2; i++)
            {
                if (i % n2 == 0)
                    c2++;
            }
            d = Math.Abs(n1 - n2);
            if (d == 2 && c1 == 2 && c2 == 2)
                Console.WriteLine("Twin Prime");
            else
                Console.WriteLine("Not a Twin Prime");
        }
    }
}
