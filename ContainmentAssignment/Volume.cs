using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.ContainmentAssignment
{
    class Volume
    {
        public void volume(double r)
        {
            double V = (4 / 3) * (22 / 7) * r * r * r;
        }
        public void volume(double h, double r)
        {
            double v = 22 / 7 * r * r * h;
        }
        public void volume(double l, double b, double h)
        {
            double v = l * b * h;
        }

        static void Main(string[] args)
        {
            Volume v = new Volume();
            v.volume(2);
            v.volume(3, 4);
            v.volume(5, 9, 6);
        }
    }
}
