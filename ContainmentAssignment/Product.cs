using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.ContainmentAssignment
{
    class Order_2
    {
        int ordered;
        string Orderdate;
        Customer cust;
        Item item;

        public Order_2()
        {

        }

        public Order_2(int ordered, string orderdate)
        {
            this.Ordered = ordered;
            this.Orderdate1 = orderdate;
        }

        public int Ordered { get => ordered; set => ordered = value; }
        public string Orderdate1 { get => Orderdate; set => Orderdate = value; }
        internal Customer Cust { get => cust; set => cust = value; }
        internal Item Item { get => item; set => item = value; }
    }
    class Customer
    {
        int custid;
        string custname;
        Address address = new Address();

        public Customer()
        {

        }

        public Customer(int custid, string custname)
        {
            this.Custid = custid;
            this.Custname = custname;
        }

        public int Custid { get => custid; set => custid = value; }
        public string Custname { get => custname; set => custname = value; }
        public Address Address { get => address; set => address = value; }
    }

    class Address
    {
        string addr1, city;
        int pincode;

        public Address()
        {

        }

        public Address(string addr1, string city, int pincode)
        {
            this.Addr1 = addr1;
            this.City = city;
            this.Pincode = pincode;
        }

        public string Addr1 { get => addr1; set => addr1 = value; }
        public string City { get => city; set => city = value; }
        public int Pincode { get => pincode; set => pincode = value; }
    }

    class Item
    {
        int itemid;
        string itemname;
        int price;

        public Item()
        {

        }

        public Item(int itemid, string itemname, int price)
        {
            this.Itemid = itemid;
            this.Itemname = itemname;
            this.Price = price;
        }

        public int Itemid { get => itemid; set => itemid = value; }
        public string Itemname { get => itemname; set => itemname = value; }
        public int Price { get => price; set => price = value; }
    }
    class Product
    {
        static void Main(string[] args)
        {
            Order_2 p = new Order_2();
            p.Ordered = 1;
            p.Orderdate1 = "21 / 5 / 2022";
            p.Cust.Custid = 1;
            p.Cust.Custname = "Prasad ";
            p.Cust.Address.Addr1 = "Ram Nagar";
            p.Cust.Address.City = "pune";
            p.Cust.Address.Pincode = 413102;
            p.Item.Itemid = 1;
            p.Item.Itemname = "Table";
            p.Item.Price = 700;

            Console.WriteLine(p.Ordered);
            Console.WriteLine(p.Orderdate1);
            Console.WriteLine(p.Cust.Custid);
            Console.WriteLine(p.Cust.Custname);
            Console.WriteLine(p.Cust.Address.Addr1);
            Console.WriteLine(p.Cust.Address.City);
            Console.WriteLine(p.Cust.Address.Pincode);
            Console.WriteLine(p.Item.Itemid);
            Console.WriteLine(p.Item.Itemname);
            Console.WriteLine(p.Item.Price);



        }
    }
}
