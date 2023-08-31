using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_HomeWork_10
{
    public interface IDBInterface
    {
        public static string hello = "Hello";
        public string Hello { get; set; }
        public void WriteHello();// { Console.WriteLine(Hello); }
        public void addUser(User newuser);
        public List<User> GetUsers();
        //Products
        public List<Product> GetProducts();
        public void addProduct(Product newproduct);
        //Orders
        public List<Order> GetOrders();
        public void addOrder(Order neworder);

    }
}
