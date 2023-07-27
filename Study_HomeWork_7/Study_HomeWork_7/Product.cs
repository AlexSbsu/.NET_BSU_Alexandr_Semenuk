using System;
namespace Study_HomeWork_7
{
    public class Product
    {
        public static int Product_gid = 1;
        readonly private int id;
        private string product_name;
        private string product_descr = "product_descr" + Product_gid.ToString();
        private double cost;

        //props
        public int Id { get => id; }
        public string Product_name { get => product_name; protected set => product_name = value; }
        public string Product_descr { get => product_descr; protected set => product_descr = value; }
        public virtual double Cost
        {
            get => cost;
            protected set { if (value >= 0) cost = value; else throw new FormatException("Cost must be > 0"); }
        }
        
        //---Constructor
        public Product(string ttovar_name, string ttovar_descr, double ccost)
        {
            id = Product_gid;
            product_name = ttovar_name;
            product_descr = ttovar_descr;
            cost = ccost;
            Product_gid++;
        }
        public override string ToString()
        {
            return ("id=" + this.id
                +" Product_name=" + this.Product_name
                +" Product_descr=" + this.Product_descr
                +" Cost = " + this.Cost);
        }
        public void print()
        {
            Console.WriteLine("id = " + this.id);
            Console.WriteLine("Product_name = " + this.Product_name);
            Console.WriteLine("Product_descr = " + this.Product_descr);
            Console.WriteLine("Cost = " + this.Cost);
        }
        //public override bool Equals(object obj)
        //{return (obj as Product).Id==this.Id;}

        public override bool Equals(object obj)
        {return this.GetHashCode()==obj.GetHashCode();}

        public override int GetHashCode()
        {
            return this.Id.GetHashCode() 
                    + this.Product_name.GetHashCode() 
                    + this.Product_descr.GetHashCode()
                    + this.Cost.GetHashCode();
        }
    }
}
