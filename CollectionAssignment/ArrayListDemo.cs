using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace TQ_Apple.CollectionAssignment
{
    class ArrayListDemo
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add("Welcome");
            Console.WriteLine(al.Count);
            Console.WriteLine(al.Capacity);
            al.Add(01);
            al.Add("Prasad ");
            al.Add("Jagtap");
            al.Add(9970089707);
            al.Add("prasad@gmail.com");
            al.Add("Baramati");
            al.Add("Pashya");

            al.Insert(3, "Laxman");
            al.Remove("Pashya");
            //al.RemoveAt(8);
            //al.Reverse();
            for (int i = 0; i < al.Count; i++)
            {
                Console.WriteLine(al[i]);
            }
            /* Console.WriteLine("***********");
             foreach(object i in al)
                 Console.WriteLine(i);*/




        }
    }
}
