using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple
{
    class EmpSalary
    {
        static void Main(string[] args)
        {
            float basic, gross, da, hra;
            Console.WriteLine("Enter basic salary of an employee:");
            basic = Convert.ToSingle(Console.ReadLine());

            if (basic <= 10000)
            {
                da = basic * 0.8f;
                hra = basic * 0.2f;
            }
            else if (basic <= 20000)
            {
                da = basic * 0.9f;
                hra = basic * 0.25f;
            }
            else
            {
                da = basic * 0.95f;
                hra = basic * 0.3f;
            }


            gross = basic + hra + da;
            Console.WriteLine("----------------------------Employee Salary ---------------");

            Console.WriteLine("Basic =  " + basic);
            Console.WriteLine("HRA =  " + hra);
            Console.WriteLine("DA=  " + da);
            Console.WriteLine("GROSS SALARY OF EMPLOYEE =  " + gross);




        }
    }
    
}
