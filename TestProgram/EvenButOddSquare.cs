using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.TestProgram
{
    class EvenButOddSquare
    {
        static void Main(string[] args)
        {

            for(int i=1;i<=50;i++)
            {
                if(i%2==0)
                {
                    Console.WriteLine("even Number : "+i);
                }else
                {
                    Console.WriteLine("Odd Square :"+i*i);
                }
              
              
            }
        }
    }
}
