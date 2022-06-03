using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.CollectionAssignment
{
    class List
    {
        static void Main(string[] args)
        {
            List<string> l = new List<string>();
            l.Add("Prasad");
            l.Add("Kartik");
            l.Add("Prasad");
           // Console.WriteLine(l) ;

            foreach (string k in l)
            {
              //  Console.Write("At Position {0}: ", p);
                Console.WriteLine(k);
               // p++;
            }

        }
    }
}
