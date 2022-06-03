using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.Loops
{
    class CountNumberOfDigit
    {
        static void Main(string[] args)
        {
            int i, n=123;
            int count = 0;

            while (n != 0)
            {
               
                n = n / 10;
                count++;
            }
            Console.WriteLine("Count the Number Of Digits  :"+count);      
            
        }
    }
}
