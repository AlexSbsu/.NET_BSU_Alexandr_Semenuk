using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_HomeWork_10
{
    internal class InMemoryDatabase_fake:IDBInterface
    {
        public static string hello = "Hello";
        public string Hello { get; set; }
        public void WriteHello()
        { }
        public void addUser(User newuser)
        {
            Console.WriteLine("addUser from InMemoryDatabase2");
        }
        public List<User> GetUsers()
        {
            Console.WriteLine("GetUsers from InMemoryDatabase2");
            return new List<User>();
        }
        //Products
        public List<Product> GetProducts()
        {
            Console.WriteLine("GetProducts from InMemoryDatabase2");
            return new List<Product>();
        }
        public void addProduct(Product newproduct)
        {
            Console.WriteLine("addProduct from InMemoryDatabase2");
        }
        //Orders
        public List<Order> GetOrders()
        {
            Console.WriteLine("GetOrders from InMemoryDatabase2");
            return new List<Order>();
        }
        public void addOrder(Order neworder)
        {
            Console.WriteLine("addOrder from InMemoryDatabase2");
        }
    }
}
