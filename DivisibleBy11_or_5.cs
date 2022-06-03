using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple
{
    class DivisibleBy11_or_5
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter The number ");
            int num =Convert.ToInt32(Console.ReadLine());

            if ((num % 5 == 0) && (num % 11 == 0))
            {
                Console.WriteLine("Number is divisible by 5 and 11");
            }
            else
            {
                Console.WriteLine("Number is not divisible by 5 and 11");
            }


        }

    }
}
