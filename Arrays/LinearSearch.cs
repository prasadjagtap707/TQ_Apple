using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.Arrays
{
    class LinearSearch
    {
        static void Main(string[] args)
        {
            int[] a = { 52, 54, 5, 485, 4, 84, 6, 10 };
            Console.WriteLine("Enter the search Element :");

            int Search = int.Parse(Console.ReadLine());

            for(int i=0;i<a.Length;i++)
            {
                if(a[i]==Search)
                {
                    Console.WriteLine(a[i]+"Element found at position "+i);
                }
            }
            
        }
    }
}
