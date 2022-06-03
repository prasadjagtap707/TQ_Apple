using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.Loops
{
    class PrintTable
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the Integer : ");
            int n= Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; ++i)
            {
                Console.WriteLine( "{0} * {1} = {2} \n", +n, +i, +n * +i);
            }

        }
    }
}
