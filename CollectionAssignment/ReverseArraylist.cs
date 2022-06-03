using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace TQ_Apple.CollectionAssignment
{
    class ReverseArraylist
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add("Sun");
            al.Add("Mon");
            al.Add("Sat");
            al.Add("Sun ");
            al.Add("Mon ");
            al.Add("Sat ");
            al.Add("Sun ");
            al.Add("Sat ");
            al.Add("Sun ");
            al.Add("Mon ");
            Console.WriteLine("Before Arraylist.........");
            foreach (object i in al)
                Console.Write(i + " ");
            Console.WriteLine();

            Console.WriteLine("Sorting..........");
            al.Sort();

            foreach (object i in al)
                Console.Write(i + " ");

            al.Reverse();
            Console.WriteLine();

            Console.WriteLine("Reserve...........");

            foreach (object i in al)
                Console.Write(i + " ");

            Console.WriteLine(" ");
            Console.WriteLine("Removing Duplicate Elements : ");
            for(int i=0;i<al.Count;i++)
            {
                int c = 0;
                for(int j=0;j<al.Count;j++)
                {
                    if(al[i].Equals(al[j])&& c==1)
                    {
                        al.RemoveAt(j);
                    
                    }
                    else if(al[j]==al[i])
                    {
                        c++;
                    }
                   
                }
               
            }
            foreach (var a in al)

                Console.WriteLine(a);


        }
    }
}
