using System;
using System.Text;

namespace Study_HomeWork_6
{
    public class Order:IComparable<Order>
    {
        readonly private string objectname;
        public static int gid = 1;
        readonly private int id;
        private string name = "name"+gid.ToString();
        private string surname = "surname" + gid.ToString();
        private string patrname = "patrname" + gid.ToString();
        private string tel;
        private string address = "address" + gid.ToString();
        private string product_name;
        private string product_descr = "product_descr" + gid.ToString();
        private double cost;
        private int amount;
        private const int currency=1;

        public string Objectname { get => objectname; }
        public int Id { get => id;} 
        public string Name {
            get => name;
            protected set { if(!string.IsNullOrEmpty(value)) name = value; }}
        public string Surname { 
            get => surname;
            protected set { if (!string.IsNullOrEmpty(value)) Surname = value; }}
        public string Patrname {
            get => patrname;
            protected set { if (!string.IsNullOrEmpty(value)) Surname = value; }
        }
        public string Tel
        {
            get => tel;
            protected set { if (!string.IsNullOrEmpty(value)) tel = value; }
        }
        public string Address { get => address; protected set => address = value; } 
        public string Product_name { get => product_name; protected set => product_name = value; } 
        public string Product_descr { get => product_descr; protected set => product_descr = value;}
        public double Cost
        {
            get => cost;
            protected set { if (value >= 0) cost = value; else throw new FormatException("Cost must be > 0"); }
        }
        public int Amount { get => amount; protected set => amount = value; }

        //---Constructor
        public Order(string nname, string ssurname, string ppatrname,string ttel, string aaddress,
            string ttovar_name, string ttovar_descr, double ccost, int aamount)
        {
            id = gid;
            objectname = "Order" + id;
            name = nname;
            surname = ssurname;
            patrname = ppatrname;
            tel = ttel;
            address = aaddress;
            product_name = ttovar_name;
            product_descr = ttovar_descr;
            cost = ccost;
            amount = aamount;
            gid++;
        }
        public Order(string ttel, string ttovar_name, double ccost, int aamount)
        {
            id = gid;
            objectname = "Order" + id;
            tel = ttel;
            product_name = ttovar_name;
            cost = ccost;
            amount = aamount;
            gid++;
        }
        //Call default constructor from another
        public Order(string ttel, string aaddress,
            string ttovar_name, string ttovar_descr, double ccost, int aamount)
            :this(ttel, ttovar_name, ccost, aamount)
        {
            tel = ttel;
            address = aaddress;
            product_name = ttovar_name;
            product_descr = ttovar_descr;
            cost = ccost;
            amount = aamount;
        }
        //Calculate full cost
        public double fulcost(){return Cost * Amount * currency;}
        public void print_order() 
        {
            Console.WriteLine("id = " + this.Id);
            Console.WriteLine("Name = " + this.Name);
            Console.WriteLine("Surname = " + this.Surname);
            Console.WriteLine("Patrname = " + this.Patrname);
            Console.WriteLine("Tel = " + this.Tel);
            Console.WriteLine("Address = " + this.Address);
            Console.WriteLine("Product_name = " + this.Product_name);
            Console.WriteLine("Product_descr = " + this.Product_descr);
            Console.WriteLine("Cost = " + this.Cost);
            Console.WriteLine("Amount = " + this.Amount);
            Console.WriteLine("Full Cost = " + this.fulcost());
        }
        public int CompareTo(Order or)
        {
            double flcost1 = this.fulcost();
            double flcost2 = or.fulcost();
            return flcost1.CompareTo(flcost2);
            //return Cost.CompareTo(or.cost);
        }
    }
}
