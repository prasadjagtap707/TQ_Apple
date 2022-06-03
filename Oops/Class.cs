using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.Oops
{
    class Class
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int count = 0;
                
            for (int i = 0; i <= 9; i++)
            {
                  
                        if (i % 2 == 0)
                        {
                            //Console.Write("*.");
                            count = 1;
                    
                    
                        }
            }
            if (count == 0)
            {
                Console.Write("Number is not Happy.");
            }
            else
            {
                Console.WriteLine("Happy");
            }
            /*

            while(n!=0)
            {
                n = n / 10;
               
                if(n%2==0)
                
                    count=1;
                else
                
                if(count==0)
                {
                    Console.WriteLine("Happy");
                    
                }
                else
                {
                    Console.WriteLine("not happy");
                    
                }
            */
                
            }
            
        }

    }


    

