﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.Arrays
{
    class RearrangePositiveNegative
    {
        static void Main(string[] args)
        {
           int[] A = { 9, -3, 5, -2, -8, -6, 1, 3 };

            rearrange(A);

            // print the rearranged array
            //Console.WriteLine(Arrays.ToString(A));
        }
        public static int partition(int[] A)
        {
            int j = 0;
            int pivot = 0;    // consider 0 as a pivot

            // each time we find a negative number, `j` is incremented,
            // and a negative element would be placed before the pivot
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] < pivot)
                {
                    // swap `A[i]` with `A[j]`
                    int temp = A[i];
                    A[i] = A[j];
                    A[j] = temp;

                    j++;
                }
            }

            // `j` holds the index of the first positive element
            return j;
        }

        // Function to rearrange a given array such that it contains positive
        // and negative numbers at alternate positions
        public static void rearrange(int[] A)
        {
            // partition a given array such that all positive elements move
            // to the end of the array

            int p = partition(A);

            // swap alternate negative elements from the next available positive
            // element till the end of the array is reached, or all negative or
            // positive elements are exhausted.

            for (int n = 0; (p < A.Length && n < p); p++, n += 2)
            {
                // swap `A[n]` with `A[p]`
                int temp = A[n];
                A[n] = A[p];
                A[p] = temp;
            }
        }

    }
}
