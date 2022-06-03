using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.ContainmentAssignment
{

    class SalaryBased1 : Teacher1
    {
        int salary;

        public void Salary()
        {
            Console.WriteLine("salary is " + salary);
        }
        public SalaryBased1()
        {
            Console.WriteLine("In salary default constructor");
        }

        public SalaryBased1(int salary)
        {
            this.salary = salary;
        }

    }


    class TeacherTest
    {

        static void Main(string[] args)
        {
            SalaryBased1 s1 = new SalaryBased1(15000);
            s1.Salary();
            HourlyBased h1 = new HourlyBased();
            h1.Salary(500, 10);
        }
    }
}
