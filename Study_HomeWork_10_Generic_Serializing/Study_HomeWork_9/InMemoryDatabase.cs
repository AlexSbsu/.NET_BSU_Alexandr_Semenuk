using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_HomeWork_10

{
    internal class InMemoryDatabase : IUpdatedDatabase  //: IDBInterface
    {
        public  GenericSupport<User> users { get; private set; }
        public  GenericSupport<Order> orders { get; private set; }
        public  GenericSupport<Product> products { get; private set; }

        public string Hello { get=>IDBInterface.hello; set=> IDBInterface.hello=value; }
        public void WriteHello() { Console.WriteLine(Hello); }

        public InMemoryDatabase()
        {
            users = new GenericSupport<User>();
            orders = new GenericSupport<Order>();
            products = new GenericSupport<Product>();

            users.AddItem(new User("user1", "1", "1", "+111111111111", "1"));
            users.AddItem(new User("user2", "2", "2", "+222222222222", "2"));
            users.AddItem(new User("user3", "3", "3", "+333333333333", "3"));

            products.AddItem(new Product("prod1", "prod1 description", 1));
            products.AddItem(new Product("prod2", "prod2 description", 1));
            products.AddItem(new Product("prod3", "prod3 description", 1));

            //orders.AddItem(new Order(users [0], products[0], 1);
            //orders.AddItem(new Order(users[1], products[1], 2));
          

            DiscountProduct discount_product1 = new DiscountProduct("prod3", "prod3 description", 200, 50);
        }
        //Users
        public void addUser(User newuser)
        {
            users.AddItem(newuser);
        }
        public List<User> GetUsers()
        {
            List<User> copyusers = new List<User>(users.GetItems());
            return copyusers;
        }
        //Products
        public List<Product> GetProducts()
        {
            List<Product> copyproducts = new List<Product>(products.GetItems());
            return copyproducts;
        }
        public void addProduct(Product newproduct)
        {
            products.AddItem(newproduct);
        }
        //Orders
        public List<Order> GetOrders()
        {
            List<Order> copyorders = new List<Order>(orders.GetItems());
            return copyorders;
        }
        public void addOrder(Order neworder)
        {
            orders.AddItem(neworder);
        }
        public void SaveDBToFile()
        {
            //string users_serial_string = JsonConvert.SerializeObject(users.GetItems());

            /*only for full object with public fields
            string users_serial_string = JsonConvert.SerializeObject(users);
            Console.WriteLine("users_serial_string = " + users_serial_string);                       
            string products_serial_string = JsonConvert.SerializeObject(products);
            Console.WriteLine("products_serial_string = " + products_serial_string);
            string orders_serial_string = JsonConvert.SerializeObject(orders);
            Console.WriteLine("orders_serial_string = " + orders_serial_string);
            */

            //only for List with private fields
            string users_serial_string = JsonConvert.SerializeObject(users.GetItems());
            Console.WriteLine("users_serial_string = " + users_serial_string);
            string products_serial_string = JsonConvert.SerializeObject(products.GetItems());
            Console.WriteLine("products_serial_string = " + products_serial_string);
            string orders_serial_string = JsonConvert.SerializeObject(orders.GetItems());
            Console.WriteLine("orders_serial_string = " + orders_serial_string);

            File.WriteAllText("users_serialized.txt", users_serial_string);
            File.WriteAllText("products_serialized.txt", products_serial_string);
            File.WriteAllText("orders_serialized.txt", orders_serial_string);

            Console.WriteLine("Users are save to users_serialized.txt");
            Console.WriteLine("Products are save to products_serialized.txt");
            Console.WriteLine("Orders are save to orders_serialized.txt");
        }
        public void RestoreDBFromFile()
        {
            /*only for full object with public fields
            string users_serial_string = File.ReadAllText("users_serialized.txt");
            Console.WriteLine("--->users_serial_string = " + users_serial_string);
            users = JsonConvert.DeserializeObject<GenericSupport<User>>(users_serial_string);            
            string products_serial_string = File.ReadAllText("products_serialized.txt");
            Console.WriteLine("--->products_serial_string = " + products_serial_string);
            products = JsonConvert.DeserializeObject<GenericSupport<Product>>(products_serial_string);
            string orders_serial_string = File.ReadAllText("orders_serialized.txt");
            Console.WriteLine("--->orders_serial_string = " + products_serial_string);
            orders = JsonConvert.DeserializeObject<GenericSupport<Order>>(orders_serial_string);
            */

            string users_serial_string = File.ReadAllText("users_serialized.txt");
            Console.WriteLine("--->users_serial_string = " + users_serial_string);
            List<User> lu = JsonConvert.DeserializeObject<List<User>>(users_serial_string);
            foreach(var u in lu) Console.WriteLine(u.Id + " " + u.Name + " " + u.Surname + " " + u.Patrname + " " + u.Tel + " " + u.Address);
            users.AddItems(JsonConvert.DeserializeObject<List<User>>(users_serial_string));
        }

    }
}

