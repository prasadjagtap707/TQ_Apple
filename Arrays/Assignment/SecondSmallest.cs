using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.Arrays.Assignment
{
    class SecondSmallest
    {
        static void Main(string[] args)
        {
			int i, j, temp;
			int[] arr = new int[5];

			Console.Write("Enter five numbers:");
			for (i = 0; i < arr.Length; i++)
			{
				arr[i] = Convert.ToInt32(Console.ReadLine());
			}

			for (i = 0; i < 5; i++)
			{
				for (j = i + 1; j < 5; j++)
				{
					if (arr[i] > arr[j])
					{
						temp = arr[i];
						arr[i] = arr[j];
						arr[j] = temp;
					}
				}
			}
			Console.WriteLine("Second smallest element:" + arr[1]);
		}
    }
}
