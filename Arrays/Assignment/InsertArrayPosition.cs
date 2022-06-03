﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.Arrays.Assignment
{
    class InsertArrayPosition
    {
        static void Main(string[] args)
        {
            int i = 0;
            int pos = 0;
            int item = 0;
            int[] arr = new int[10];

            //Read numbers into array
            Console.WriteLine("Enter numbers : ");
            for (i = 0; i < 5; i++)
            {
                Console.Write("Element[" + (i + 1) + "]: ");
                arr[i] = int.Parse(Console.ReadLine());
            }


            Console.Write("Enter position : ");
            pos = int.Parse(Console.ReadLine());

            Console.Write("Enter new item : ");
            item = int.Parse(Console.ReadLine());

            //Perform shift opearation
            for (i = 5; i >= pos; i--)
            {
                arr[i] = arr[i - 1];
            }

            arr[pos - 1] = item;

            //print array after insertion
            Console.WriteLine("Array elements after insertion : ");
            for (i = 0; i < 6; i++)
            {
                Console.WriteLine("Element[" + (i + 1) + "]: " + arr[i]);
            }

            Console.WriteLine();
        }
    }
}
