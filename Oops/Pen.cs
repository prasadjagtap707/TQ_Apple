using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.Oops
{
    class Pen
    {
        string brand;
        string colour;
        int price;

        public Pen()
        {
            Console.WriteLine("In Pen Constructor");
        }
        public void setBrand(string bname)
        {
            brand = bname;
        }
        public string getBrand()
        {
            return brand;
        }
        public void setColour(string cname)
        {
            colour = cname;
        }
        public string getColour()
        {
            return colour;
        }
        public void setPrice(int pr)
        {
            price = pr;
        }
        public int getPrice()
        {
            return price;
        }

        static void Main(string[] args)
        {
            Pen p = new Pen();
            Console.WriteLine("Enter The Pen Brand Name");
            string pb = Console.ReadLine();
            p.setBrand(pb);

            Console.WriteLine("Enter The Pen Colour");
            string pc = Console.ReadLine();
            p.setColour(pc);

            Console.WriteLine("Enter The Pen Price");
            int pp = Convert.ToInt32(Console.ReadLine());
            p.setPrice(pp);

            Console.WriteLine(p.getBrand());
            Console.WriteLine(p.getColour());
            Console.WriteLine(p.getPrice());

            Pen p1 = new Pen();
            p1.setBrand("Cello");
            p1.setColour("White");
            p1.setPrice(20);

            Console.WriteLine(p1.getBrand());
            Console.WriteLine(p1.getColour());
            Console.WriteLine(p1.getPrice());


        }
    }
}
