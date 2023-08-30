using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_HomeWork_9
{    
        public class Order : BaseModel
        {
            //readonly private string objectname;
            //public static int order_gid = 1;
            //readonly private int id;
            User user;
            //Product product;
            //private int user_id;
            private List<object[]> products = new List<object[]>(); //id,amount

            private const double currency = 1.0;

            public string Objectname { get; }
            //public int Id { get => id; }

            //---Constructor
            public Order(User uuser, Product prod, int amount)
            {
                //id = order_gid;
                Objectname = "Order" + Id;
                user = uuser;
                object[] ob_ar = { prod, amount };
                products.Add(ob_ar);
                //order_gid++;
            }

            //Calculate full cost
            public double fulcost()
            {
                double sum = 0;
                foreach (object[] ob in products) sum += (ob[0] as Product).Cost * (int)ob[1];

                return sum;
            }

            public override string ToString()
            {
                string s = "";
                foreach (object[] ob in products)
                {
                    s += ("[Product Id=" + (ob[0] as Product).Id
                    + " Product Name=" + (ob[0] as Product).Product_name
                    + " Amount=" + (int)ob[1] + "]");
                }
                return ("Order Id=" + this.Id + "User Id=" + user.Id + s);
            }
            public void print()
            {
                Console.WriteLine("Order---> ");
                Console.WriteLine("Order Id : " + this.Id);
                Console.WriteLine("User Id : " + user.Id);
                foreach (object[] ob in products)
                {
                    Console.WriteLine("Product Id=" + (ob[0] as Product).Id
                    + " Product Name: " + (ob[0] as Product).Product_name
                    + " Amount = " + (int)ob[1]);
                }
            }
            public void add(Product prod, int amount)
            {
                Console.WriteLine("--->Enter add product");
                bool found = false;
                int found_ind = 0;
                int size = products.Count;
                for (int i = 0; i < size; i++)
                {
                    if ((products[i][0] as Product).Equals(prod)) { found = true; found_ind = i; }
                    Console.WriteLine("Product Id=" + (products[i][0] as Product).Id
                                         + " Amount=" + amount
                                         + " is added to Order Id=" + this.Id);
                }

                if (found == true) products[found_ind][1] = (Convert.ToInt32(products[found_ind][1]) + amount);
                else products.Add(new object[] { prod, amount });
            }
            public void remove(Product prod)
            {
                Console.WriteLine("--->Enter remove product");
                bool found = false;
                int found_ind = 0;
                int size = products.Count;
                for (int i = 0; i < size; i++)
                    if ((products[i][0] as Product).Id == prod.Id) { found = true; found_ind = i; }

                if (found == true)
                {
                    products.RemoveAt(found_ind);
                    Console.WriteLine("Product Id=" + prod.Id + " is removed from Order Id=" + this.Id);
                }
                else Console.WriteLine("Such product doesnt exist in Order");
            }

            //public int CompareTo(Order or)
            //{double flcost1 = this.fulcost();double flcost2 = or.fulcost();return flcost1.CompareTo(flcost2);}
        }    
}
