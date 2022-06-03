using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple
{
    class CheckPostiveNegative
    {
        static void Main(string[] args)
        {


            Console.Write("Input an integer : ");
           int  num = Convert.ToInt32(Console.ReadLine());
            if (num >= 0)

                Console.WriteLine(num+" is a positive number.\n");
            else
                Console.WriteLine(num+" is a negative number. \n");
        }
    }
}
