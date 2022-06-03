using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.TestProgram
{
    class TrimorphicNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            int flag = 0;
            int cube = num * num * num;
            while (num != 0)
            {
                if (num % 10 != cube % 10)
                {
                    flag = 1;
                    break;
                }
                num = num / 10;
                cube = cube / 10;
            }
            if (flag == 0)
                Console.WriteLine("It is a Trimorphic Number.");
            else
                Console.WriteLine("It is not a Trimorphic Number.");
        }
    }
}
