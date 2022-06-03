using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.TestProgram
{
    class IMEINumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the 15 digit Number : ");
            long num = Convert.ToInt64(Console.ReadLine());

            int count = 0;
            int sum = 0;

            while(num>0)
            {
                count++;
                long r = num % 10;
                num = num / 10;
                if(count % 2==0)
                {
                    r = r * 2;
                    if(r>9)
                    {
                        long d1 = r % 10;
                        long d2 = r / 10;
                        r = d1 + d2;
                    }
                }
                sum = sum + (int)r;
            }   
            if(count!=15)
                Console.WriteLine("Not 15 digit Number !!!");
            else if(sum%10 ==0)
                Console.WriteLine("Valid IMEI Number ");
            else
                Console.WriteLine("Not Valid IMEI Number ");
        }
    }
}
