using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple
{
    class EvenOdd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = Convert.ToInt32(Console.ReadLine());

            if(num%2==0)
            {
                Console.WriteLine(num+"  is Even ");
            }
            else
            {
                Console.WriteLine(num+"  is odd");
            }
        }
    }
}
