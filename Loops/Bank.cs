using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.Loops
{
    class Bank
    {
        static void Main(string[] args)
        {
            int amt, r2000 = 0, r500 = 0, r100 = 0, r50 = 0, r20 = 0, r10 = 0, r1 = 0, count = 0;


            Console.WriteLine("Enter The Amount in Rupees : ");
            amt = Convert.ToInt32(Console.ReadLine());

            while (amt >= 2000)
            {
                r2000 = amt / 2000;
                amt = amt % 2000;
                Console.WriteLine("\nTotal Number Of 2000 Rupees Notes :" + r2000);
                break;
            }
            while (amt >= 500)
            {
                r500 = amt / 500;
                amt = amt % 500;
                Console.WriteLine("\nTotal Number Of 500 Rupees Notes : " + r500);
                break;
            }
            while (amt >= 100)
            {
                r100 = amt / 100;
                amt = amt % 100;
                Console.WriteLine("\nTotal Number Of 100 Rupees Notes : " + r100);
                break;
            }
            while (amt >= 50)
            {
                r50 = amt / 50;
                amt = amt % 50;
                Console.WriteLine("\nTotal Number Of 50 Rupees Notes : " + r50);
                break;
            }
            while (amt >= 20)
            {
                r20 = amt / 20;
                amt = amt % 20;
                Console.WriteLine("\nTotal Number Of 20 Rupees Notes : " + r20);
                break;
            }
            while (amt >= 10)
            {
                r10 = amt / 10;
                amt = amt % 10;
                Console.WriteLine("\nTotal Number Of 10 Rupees Notes Or Coin : " + r10);
                break;
            }

            while (amt >= 1)
            {
                r1 = amt / 1;
                amt = amt % 1;
                Console.WriteLine("\nTotal Number Of 1 Rupees Note Or Coin : " + r1);
                break;
            }
            count = r2000 + r500 + r100 + r50 + r20 + r10 + r1;
            Console.WriteLine("\n\nTotal Number Of Notes Require : \n\n" + count);
        }
    }
}
