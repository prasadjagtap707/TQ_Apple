using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.Arrays.Assignment
{
    class SingleArray1D
    {
        static void Main(string[] args)
        {
            int[] a= new int[5];
            a[0] = 10;
            a[1] = 45;
            a[2] = 25;
            a[3] = 20;
            a[4] = 21;

            Console.WriteLine("All the element of array is:\n\n");

            Console.Write("\t1\t2\t3\t4\t5\n\n\t");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("{0}\t", a[i]);
            }
            Console.ReadLine();
        }
    }
    
}
