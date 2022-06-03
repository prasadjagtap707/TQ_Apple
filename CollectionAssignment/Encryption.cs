using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace TQ_Apple.CollectionAssignment
{
    class StringReverse
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList(8);
            Console.WriteLine("Enter words");
            for (int i = 0; i < al.Capacity; i++)
            {
                al.Add(Console.ReadLine());
            }
            Console.WriteLine("*********");

            al.Sort();
            al.Reverse();
            foreach (var v in al)
            {
                Console.Write(v + " ");
            }

        }
    }
    class Encryption
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A String:");
            string s = Console.ReadLine();
            string[] str = s.Split();
            int[] arr = new int[str.Length];

            for (int i = 0; i < str.Length; i++)
            {
                int total = 0;

                char[] ch = str[i].ToCharArray();
                for (int j = 0; j < str[i].Length; j++)
                {
                    if (ch[j] >= 65 && ch[j] <= 90)
                    {
                        total = total + (ch[j] - 64);
                    }

                }
                Console.WriteLine(total);

                arr[i] = total;
            }


            for (int i = 0; i < arr.Length; i++)
            {


                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        string temp = str[i];
                        str[i] = str[j];
                        str[j] = temp;

                        int temp1 = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp1;

                    }
                }
                Console.Write(str[i] + " ");
                //Console.Write(str[i] + " ");
            }



        }
    }
}
