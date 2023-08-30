using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_HomeWork_9

{
    internal class InMemoryDatabase: IDBInterface
    {
        public static List<User> users;
        public static List<Product> products;
        public static List<Order> orders;

        public string Hello { get=>IDBInterface.hello; set=> IDBInterface.hello=value; }
        public void WriteHello() { Console.WriteLine(Hello); }

        public InMemoryDatabase()
        {
            users = new List<User>
            {
                new User("user1", "1", "1", "+111111111111", "1"),
                new User("user2", "2", "2", "+222222222222", "2")
            };
            products = new List<Product>
            {
                new Product("prod1", "prod1 description", 1),
                new Product("prod2", "prod2 description", 1),
                new Product("prod3", "prod3 description", 1)
            };
            orders = new List<Order>
            {
                new Order(users[0], products[0], 1),
                new Order(users[1], products[1], 2)
        };

            DiscountProduct discount_product1 = new DiscountProduct("prod3", "prod3 description", 200, 50);
        }
        //Generic
        public void addGeneric(User newuser)
        {
            users.Add(newuser);
        }
        //Users
        public void addUser(User newuser)
        {
            users.Add(newuser);
        }
        public List<User> GetUsers()
        {
            List<User> copyusers = new List<User>(users);
            return copyusers;
        }
        //Products
        public List<Product> GetProducts()
        {
            List<Product> copyproducts = new List<Product>(products);
            return copyproducts;
        }
        public void addProduct(Product newproduct)
        {
            products.Add(newproduct);
        }
        //Orders
        public List<Order> GetOrders()
        {
            List<Order> copyorders = new List<Order>(orders);
            return copyorders;
        }
        public void addOrder(Order neworder)
        {
            orders.Add(neworder);
        }
    }
}

