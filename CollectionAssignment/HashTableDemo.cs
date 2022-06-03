using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace TQ_Apple.CollectionAssignment
{
        class Student
        {
            int sid;
            string name;
            public Student(int sid, string name)
            {
                this.sid = sid;
                this.name = name;
            }
            public override bool Equals(object obj)
            {
                Student s2 = (Student)obj;
                return this.sid == s2.sid && this.name == s2.name;
            }
            public override int GetHashCode()
            {
                return HashCode.Combine(sid, name);
            }
            public override string ToString()
            {
                return "Sid= " + sid + " Sname= " + name;
            }
        }
        class HashTableDemo
        {
            static void Main(string[] args)
            {
                Hashtable ht = new Hashtable();
                ht.Add(new Student(1, "Karan"), 90);
                ht.Add(new Student(2, "Prasad"), 95);
                ht.Add(new Student(3, "akshay"), 43);

            foreach (DictionaryEntry e in ht)
                {
                    Console.WriteLine(e.Key + " " + e.Value);
                }
                Console.WriteLine("******************************");
                foreach (object k in ht.Keys)
                    Console.WriteLine(k + "-->" + ht[k]);
            }
        }
    
}
