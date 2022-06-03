using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.TestProgram
{
    class AmicableNumbers
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the 1st number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the 2nd number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int sum1 = 0, sum2 = 0;
            for (int i = 1; i <= num1; i++)
            {
                if (num1 % i == 0)
                    sum1 += i;
            }
            for (int i = 1; i <= num2; i++)
            {
                if (num2 % i == 0)
                    sum2 += i;
            }
            if (sum1 == sum2)
                Console.WriteLine("These numbers are amicable.");
            else
                Console.WriteLine("These numbers are not amicable.");
            Console.WriteLine("\n");

        }
    }
}
