using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.Oops
{
    class OverLoading
    {
        int c;
        float z;
        public void add(int a, int b)
        {
            c = a + b;

        }
        public void sum(float x, float y)
        {
            z = x + y;
        }
        static void Main(string[] args)
        {
            OverLoading obj = new OverLoading();
            obj.add(10, 5);
            obj.sum(2f, 5f);
        }
    }
}
