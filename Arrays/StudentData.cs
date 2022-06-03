using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.Arrays
{
    public struct Student
    {
        public int Id;
        public string Name;
        public int Phone ;
        public string Address;

        public void SetStudent(int id, string name, int phone, string address)
        {
            Id = id;
            Name = name;
            Phone= phone;
            Address = address;
        }

        public void PrintStudent()
        {
            Console.WriteLine("Student details:");
            Console.WriteLine("\tID     : " + Id);
            Console.WriteLine("\tName   : " + Name);
            Console.WriteLine("\tphone   : " + Phone);
            Console.WriteLine("\taddress   : " + Address);

            Console.WriteLine("\n");
        }
    }
    class StudentData
    {
        static void Main(string[] args)
        {
                Student[] S = { new Student(), new Student() };

                S[0].SetStudent(101, "Prasad", 997005455,"Pune");
                S[1].SetStudent(102, "Virat", 800885900,"Baramati");

                S[0].PrintStudent();
                S[1].PrintStudent();
            }

           


        
    }
}
