using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.TestProgram
{
    class BouncyNumber
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter The number :");
            int a = Convert.ToInt32(Console.ReadLine());
            bool isIncreasing = true;
            bool isDecreasing = true;
            int next = a % 10;
            a = a / 10;

            while(a>10)
            {
                int prev = a % 10;

                if(prev>next)
                {
                    isIncreasing = false;

                }
                if(prev<next)
                {
                    isDecreasing = false;
                }
            }


        }
    }
}
