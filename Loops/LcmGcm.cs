using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.Loops
{
    class LcmGcm
    {
        static void Main(string[] args)
        {
            int a, b, Num1, Num2, temp, LCM, GCD;
            Console.WriteLine("Calculate LCM and GCD\nEnter the two numbers to Calculate..");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Calculating....");
           
            Num1 = a;
            Num2 = b;
            while (Num2 != 0)
            {
                temp = Num2;
                Num2 = Num1 % Num2;
                Num1 = temp;
            }
            GCD = Num1;
            LCM = (a * b) / GCD;
            Console.WriteLine("LCM for {0} and {1} is {2}", a, b, LCM);
            Console.WriteLine("GCD for {0} and {1} is {2}", a, b, GCD);
            Console.ReadKey();
        }
    }
}
