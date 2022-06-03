using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.Oops
{
    class Oder
    {
        int oderid;
        string oderdate;
        Customer c;
        Item item;

        public Oder()
        {

        }

        public Oder(int oderid, string oderdate, Customer c, Item item)
        {
            this.Oderid = oderid;
            this.Oderdate = oderdate;
            this.C = c;
            this.Item = item;
        }

        public int Oderid { get => oderid; set => oderid = value; }
        public string Oderdate { get => oderdate; set => oderdate = value; }
        internal Customer C { get => c; set => c = value; }
        internal Item Item { get => item; set => item = value; }
    }
    class Customer
    {
        string custName;
        int contact;
        string emailid;
        Addres addr;

        public Customer(string custName, int contact, string emailid, Addres addr)
        {
            this.CustName = custName;
            this.Contact = contact;
            this.Emailid = emailid;
            this.Addr = addr;
        }

        public string CustName { get => custName; set => custName = value; }
        public int Contact { get => contact; set => contact = value; }
        public string Emailid { get => emailid; set => emailid = value; }
        internal Addres Addr { get => addr; set => addr = value; }
    }
    class Item
    {
        int itemid;
        string itemName;
        float price;

        public Item(int itemid, string itemName, float price)
        {
            this.Itemid = itemid;
            this.ItemName = itemName;
            this.Price = price;
        }

        public int Itemid { get => itemid; set => itemid = value; }
        public string ItemName { get => itemName; set => itemName = value; }
        public float Price { get => price; set => price = value; }
    }
    class Addres
    {
        int zipcode;
        string addr;
        string city;

        public Addres(int zipcode, string addr, string city)
        {
            this.Zipcode = zipcode;
            this.Addr = addr;
            this.City = city;
        }

        public int Zipcode { get => zipcode; set => zipcode = value; }
        public string Addr { get => addr; set => addr = value; }
        public string City { get => city; set => city = value; }
    }

    class OderMain

    {
        static void Main(string[] args)
        {
            Oder o = new Oder();
            o.Oderid = 1111;
            o.Oderdate = "7 april 2022";
            o.C.CustName = "Prasad Jagtap";
            o.C.Contact = 997089707;
            o.C.Emailid = "prasad@abc.com";
            o.C.Addr.Addr = "Baramati";
            o.C.Addr.City = "Pune";
            o.C.Addr.Zipcode = 413102;
            o.Item.Itemid = 542245;
            o.Item.ItemName = "Mobile Iphone 13 pro";
            o.Item.Price = 145522;
            Console.WriteLine("***********Cutomer Order Details**************** ");
            Console.WriteLine("Oder Id : "+o.Oderid);
            Console.WriteLine("Oder Date : "+o.Oderdate);
            Console.WriteLine("Customer Name : "+o.C.CustName);
            Console.WriteLine(" Customer Name : "+o.C.Contact);
            Console.WriteLine(" customer Email ID : "+o.C.Emailid);
            Console.WriteLine("Customer Address : "+o.C.Addr);
            Console.WriteLine("Customer City : "+o.C.Addr.City);
            Console.WriteLine("zipcode : "+o.C.Addr.Zipcode);
            Console.WriteLine("Item Id : "+o.Item.Itemid);
            Console.WriteLine("Item Name :"+o.Item.ItemName);
            Console.WriteLine(" Item Price : "+o.Item.Price);
            


        }
    }
}
