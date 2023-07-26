using System;

namespace Study_HomeWork_6
{

    class MainClass
    {
        public static void Main(string[] args)
        {
            //name,surname,patrname,tel,address,product_name,product_descr,cost,amount
            Order myorder1 = new Order("name1", "surname1", "patrname1", 
                    "tel1", "address1", "product_name1", "product_descr1", 1.1,1);
            Order myorder2 = new Order("name2", "surname2", "patrnam2", 
                    "tel2", "address2", "product_name2", "product_descr2", 2.2,2);
            Order myorder3 = new Order("tel3", "address3", "product_name3", "product_descr3", 3.3, 3);

            Order[] myorder_ar =
            {
                new Order( "tel111", "tovar_name_ar1", 3, 4),
                new Order( "tel111", "tovar_name_ar1", 3, 3),
                new Order( "tel222", "tovar_name_ar2", 3, 2),
                new Order( "tel333", "tovar_name_ar3", 3, 1)
            };

            //call properties
            myorder1.print_order();
            Console.WriteLine("--------");
            myorder3.print_order();

            Console.WriteLine("\n--------");
            Console.WriteLine("Object type(Order) = " + myorder1.GetType());
            Console.WriteLine("Objects Comparison "+ myorder1.Objectname 
                                            + " and " + myorder2.Objectname +" = "+
                                                myorder1.Equals(myorder2).ToString());

            Console.WriteLine("\n----Array NOT SORTED----");
            foreach (Order or in myorder_ar)
            {
                Console.WriteLine("---Order---");
                or.print_order();
            }
            Array.Sort(myorder_ar);
            Console.WriteLine("----Array SORTED----");
            foreach (Order or in myorder_ar)
            {
                Console.WriteLine("---Order---");
                or.print_order();
            }
        }
    }
}
