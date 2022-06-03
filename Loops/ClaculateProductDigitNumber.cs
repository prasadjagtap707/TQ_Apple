using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.Loops
{
    class ClaculateProductDigitNumber
    {
        static void Main(string[] args)
        {
            int num = 1234;
            int rem;
            int prod=1;
            while (num != 0)
            {
                rem = num % 10; // get the last-digit
                prod *= rem; // calculate product of digits
                num /= 10;  // remove the last digit
            }
            Console.WriteLine("Calculate the Product digit Number :"+prod);
        }
    }
}
