using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.Arrays
{
    class ReverseArray
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            int length = arr.Length - 1;
            string strRev = null;
            while (length >= 0)
            {
                strRev = strRev + arr[length];
                length--;
            }
            Console.WriteLine();
            Console.WriteLine("Reverse Array is " + " " + strRev);
        }
    }
}
