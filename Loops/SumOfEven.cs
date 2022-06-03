using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.Loops
{
    class SumOfEven
    {
        static void Main(string[] args)
        {

            int i = 1;
            int sum=0, n = 10;
            while(i<=n)
            {
                sum += i;
                i += 2;

             
            }
            Console.WriteLine("Sum of all even numbers  "+sum);
        }
    }
}
