using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.Loops
{
    class SumOfOdd
    {
        static void Main(string[] args)
        {

            int sum = 0, n = 5;
            int i = 1;

            while(i<=n)
            {
                if(i%2!=0)
                {
                    sum += i;
                }
                i++;
            }
            Console.WriteLine("Sum Of Odd Numbers : "+sum);
        }
    }
}
