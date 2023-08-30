using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_HomeWork_9
{
    class MainClass
    {
        public static void Main()
        {       
            IDBInterface meDB1 = DBCreator.CreateDatabase();
           
            meDB1.addUser(new User("user3", "3", "3", "+333333333333", "3"));
            var userlist = meDB1.GetUsers();
            var prodlist = meDB1.GetProducts();
            var orderlist = meDB1.GetOrders();
            
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
