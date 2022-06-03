using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.Oops
{
    class Employee
    {
        private int empid;
        private string epmname;
        private int salary;

        public void setEmployeeId(int id)
        {
            empid = id;
        }
        public int getEmployeeId()
        {
            return empid;
        }
        public void setEmployeeName(string name)
        {
            epmname = name;
        }
        public string getEmployeeName()
        {
            return epmname;
        }

        public void setEmployeeSalary(int sal)
        {
            salary = sal;
        }
        public int getEmployeeSalary()
        {
            return salary;
        }
        static void Main(string[] args)
        {
            Employee e = new Employee();
            Console.WriteLine("Enter The Employee id");
            int i = Convert.ToInt32(Console.ReadLine());
            e.setEmployeeId(i);

            Console.WriteLine("Enter The Employee Name");
            string n = Console.ReadLine();
            e.setEmployeeName(n);



        }
    }
}

