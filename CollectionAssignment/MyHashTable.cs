using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace TQ_Apple.CollectionAssignment
{
    class MyHashTable
    {
        static void Main(string[] args)
        {
            string s = "shanaya";
            char[] arr = s.ToCharArray();

            Hashtable ht = new Hashtable();
            foreach (char c in arr)
            {
                if (ht.ContainsKey(c))
                {
                    int oldvalue = (int)ht[c];
                    ht[c] = oldvalue + 1;
                }
                else
                    ht.Add(c, 1);
            }
            foreach (DictionaryEntry d in ht)
            {
                Console.WriteLine(d.Key + "->" + d.Value);
            }



        }
    }
}
