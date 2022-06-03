using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.Loops
{
    class BasePower
    {
        static void Main(string[] args)
        {
            int Base;
            int exp;
            double result = 1.0;
            Console.WriteLine("Enter a base number: ");
            Base = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Enter an exponent: ");
            exp = Convert.ToInt32(Console.ReadLine());

            while (exp != 0)
            {
                result *= Base;
                --exp;
            }
            Console.WriteLine(" Answer =  "+result);
        }
    }
}
