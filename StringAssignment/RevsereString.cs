using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.StringAssignment
{
   public class RevString
    {
        public static void Main()
        {
            Console.WriteLine("enter the atring : ");
            string str = Console.ReadLine();
            reverses(str);
        }
        static void reverses(string str)
        {
            char[] inputArray = str.ToCharArray();
            char[] result = new char[inputArray.Length];


            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] == ' ')
                {
                    result[i] = ' ';
                }
            }

            int j = result.Length - 1;
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] != ' ')
                {
                    if (result[j] == ' ')
                    {
                        j--;
                    }
                    result[j] = inputArray[i];
                    j--;
                }
            }
            for (int i = 0; i < result.Length; i++)
                Console.Write(result[i]);
        }

    }
        
   
}
