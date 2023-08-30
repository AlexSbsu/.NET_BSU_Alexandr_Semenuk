using System;

namespace Study_HomeWork_8
{

    class MainClass
    {
        public static void Main(string[] args)
        {
            /*
            Console.WriteLine("---User---");
            User user1 = new User("user1", "1", "1", "+111111111111", "1");
            User user2 = new User("user2", "2", "2", "+222222222222", "2");
            User user3 = new User("user3", "3", "3", "3", "3");
            Console.WriteLine("user1.ToString() : " + user1.ToString());
            user1.print();

            Console.WriteLine("---Product---");
            Product product1 = new Product("prod1", "prod1 description", 1);
            Console.WriteLine("product1.ToString() : " + product1.ToString());
            product1.print();
            Product product2 = new Product("prod2", "prod2 description", 1);
            //Product product3 = new Product("prod3", "prod3 description", 1);
            DiscountProduct discount_product1 = new DiscountProduct("prod3", "prod3 description", 200, 50);
            Console.WriteLine("discount_product1.ToString() : " + discount_product1.ToString());


            Console.WriteLine("---Order---");
            Order order1 = new Order(user1, product1, 1);
            //Order order2 = new Order(user2, product1, 1);
            Console.WriteLine("order1.ToString() : " + order1.ToString());
            order1.print();
            order1.add(product2, 2);
            order1.print();
            order1.add(product2, 2);
            order1.print();
            order1.remove(product2);
            order1.print();
           
    */
            var meDB1 = new InMemoryDatabase();
            meDB1.addUser(new User("user3", "3", "3", "+333333333333", "3"));
            var userlist = meDB1.GetUsers();
      //      foreach (User u in userlist) Console.WriteLine(u.ToString());

            var prodlist = meDB1.GetProducts();
        //    foreach (Product p in prodlist) Console.WriteLine(p.ToString());

            var orderlist = meDB1.GetOrders();
          //  foreach (Order o in orderlist) Console.WriteLine(o.ToString());
             
        //    Console.WriteLine("Press Enter to continue in shop-cycle");
          //  Console.ReadLine();
            //Console.Clear();
            string uname, utel;
            string pname, pcost;
            string oname, r;
            while (true)
            {
                Console.WriteLine("Select option:");
                Console.WriteLine("1.List Users");
                Console.WriteLine("11.Add user");
                Console.WriteLine("2.List Products");
                Console.WriteLine("21.Add Products");
                Console.WriteLine("3.List Orders");
                Console.WriteLine("31.List Orders");
                Console.WriteLine("0.Exit");
                string s = Console.ReadLine();
                switch (s)
                {
                    case "1":
                        Console.Clear();
                        userlist = meDB1.GetUsers();
                        foreach (User u in userlist) Console.WriteLine(u.ToString());
                        Console.WriteLine("\nPress Enter to continue");
                        break;
                    case "11":
                        Console.Clear();
                        Console.WriteLine("Enter user name:");
                        uname = Console.ReadLine();
                        Console.WriteLine("Enter phone in format : '+'12digits' like +123456789012");
                        utel = Console.ReadLine();
                        meDB1.addUser(new User(uname, utel));
                        Console.WriteLine("\nPress Enter to continue");
                        break;
                    case "2":
                        Console.Clear();
                        prodlist = meDB1.GetProducts();
                        foreach (Product p in prodlist) Console.WriteLine(p.ToString());
                        Console.WriteLine("\nPress Enter to continue");
                        break;
                    case "21":
                        Console.Clear();
                        Console.WriteLine("Enter product name:");
                        pname = Console.ReadLine();
                        Console.WriteLine("Enter cost:");
                        pcost = Console.ReadLine();
                        meDB1.addProduct(new Product(pname, "description", Convert.ToDouble(pcost)));
                        Console.WriteLine("\nPress Enter to continue");
                        break;
                    case "3":
                        Console.Clear();
                        orderlist = meDB1.GetOrders();
                        foreach (Order o in orderlist) Console.WriteLine(o.ToString());
                        Console.WriteLine("\nPress Enter to continue");
                        break;
                    case "31":
                        Console.Clear();
                        orderlist = meDB1.GetOrders();
                        foreach (Order o in orderlist) Console.WriteLine(o.ToString());
                        Console.WriteLine("\nPress Enter to continue");
                        break;
                    case "0":
                        return;
                }
            }
        }
    }
}
