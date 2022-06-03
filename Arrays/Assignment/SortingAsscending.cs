using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.Arrays.Assignment
{
    class SortingAsscending
    {
        static void Main(string[] args)
        {
            int[] list = { 98, 23,770, 97, 36, 77 };
            Console.WriteLine("Original Unsorted List");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Array.Sort(list);
            Console.WriteLine("\nSorted List");
            for (int i = 0; i < list.Length; i++)
            {
                Console.Write(list[i] + " ");
            }
        }
    }
}
