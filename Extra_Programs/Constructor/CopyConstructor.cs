using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.Extra_Programs.Constructor
{
    class CopyConstructor
    {
        private int age;
        private string name;
        
        public CopyConstructor(CopyConstructor stud)
        {
            age = stud.age;
            name = stud.name;

        }
        CopyConstructor(string name,int age)
        {
            this.name = name;
            this.age = age;
        }
        public string Details     // Get deatils of stud
        {
            get
            {
                return " The age of " + name + " is " + age.ToString();
            }
        }

        static void Main(string[] args)
        {
            CopyConstructor cc = new CopyConstructor("Prasad", 26);
            CopyConstructor cc1 = new CopyConstructor(cc);

            Console.WriteLine(cc1.Details);
        }
    }
}
