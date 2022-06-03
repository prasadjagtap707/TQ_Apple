using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.Arrays
{
    class BinarySerach
    {
        static void Main(string[] args)
        {
            int[] a = new int[100];
            Console.WriteLine("Number of elements in the array ?");
             int  s = Convert.ToInt32(Console.ReadLine());
            int x = s;
           
            Console.WriteLine(" Enter array elements ");
        
            for (int i = 0; i < x; i++)
            {
                int s1 = Convert.ToInt32(Console.ReadLine());
                a[i] = s1;
            }

            Console.WriteLine("Enter Search element");
     
            int s3 = Convert.ToInt32(Console.ReadLine());
            int x2 = s3;
            int low = 0;
            int high = x - 1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (x2 < a[mid])
                    high = mid - 1;
                else if (x2 > a[mid])
                    low = mid + 1;
                else if (x2 == a[mid])
                {
                    Console.WriteLine("Search successful");
                    Console.WriteLine("Element {0} found at location {1}\n", x2, mid + 1);
                    
                }
            }
            Console.WriteLine("Search unsuccessful");
        }
    }
}
