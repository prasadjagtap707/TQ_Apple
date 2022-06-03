using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.Loops
{
    class Krishnamurthy
    {
        static void Main(string[] args)
        {
            int  temp, sum, currentDigit, fact;
            Console.WriteLine( "Enter an Integer: ");
            int number = Convert.ToInt32(Console.ReadLine());
            temp = number;
            sum = 0;

            while (temp != 0)
            {
                currentDigit = temp % 10;
                fact = 1;

                for (int i = 1; i <= currentDigit; i++)
                {
                    fact *= i;
                }

                sum += fact;
                temp /= 10;
            }

            if (sum == number)
            {
                Console.WriteLine("  Krishnamurthy Number.", +number);
            }
            else
            {
                Console.WriteLine("  not a Krishnamurthy Number.", +number);
            }

        }

    }
}
