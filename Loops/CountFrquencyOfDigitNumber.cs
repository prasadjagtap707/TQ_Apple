using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.Loops
{
    class CountFrquencyOfDigitNumber
    {
        static void Main(string[] args)
        {
            int i, n=123440003, r,j, ctr;
            i = 0;
            while(i<10)
            //for (i = 0; i < 10; i++)
            {
                Console.WriteLine("The frequency of "+i+ " = "); 
                ctr = 0;
                j = n;
                while (j > 0)
                {
                    r = j % 10;
                    if (r == i)
                    {
                        ctr++;
                    }
                
                    j = j / 10;
                }
                Console.WriteLine(ctr);
                i++;
            }
        }
    }
}
