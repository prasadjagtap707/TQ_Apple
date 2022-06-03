using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.TestProgram
{
    class SpyNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number :  ");
            int num = Convert.ToInt32(Console.ReadLine());
            int digit, sum = 0;
            int orgNum = num;
            int prod = 1;
            while (num > 0)
            {
                digit = num % 10;

                sum += digit;
                prod *= digit;
                num /= 10;
            }
            if (sum == prod)
                Console.WriteLine(orgNum + " is Spy Number");
            else
                Console.WriteLine(orgNum + " is not Spy Number");


        }
    }
}
