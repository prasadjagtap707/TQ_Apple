using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple
{
    class MaxThreeNumber
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter The first Number : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter The Second Number : ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter The Third Number : ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 >= num2 && num1 >= num3)
            {
                Console.WriteLine(num1 + " is the maximum number.");
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                Console.WriteLine(num2 + " is the maximum number.");
            }
            else
                Console.WriteLine (num3 + " is the maximum number.");

        }
    }
}
