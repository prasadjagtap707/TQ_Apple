using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.CollectionAssignment
{
    class LinkedList
    {
        static void Main(string[] args)
        {
            LinkedList<int> ll = new LinkedList<int>();
            ll.AddFirst(10);
            ll.AddLast(20);
            //  ll.AddLast(null);
            ll.AddLast(10);
            ll.AddFirst(2);
            foreach (int ele in ll)
                Console.Write(ele);
            Console.WriteLine(ll.Remove(2));
            foreach(int ele in ll)
                Console.Write(  ele);
        }
    }
}
