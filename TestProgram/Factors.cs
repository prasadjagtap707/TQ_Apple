using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.TestProgram
{
    class Factors
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number : ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Factors of " + number + " are: ");
            int i = 1;
            while( i <= number)
            {

                if (number % i == 0)
                {
                    Console.WriteLine(i + " ");
                }
                i++;
            }
        }
    }
}
