using System;

namespace Study_HomeWork_7
{

    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("---User---");
            User user1 = new User("user1", "1", "1", "1", "1");
            User user2 = new User("user2", "2", "2", "2", "2");
            User user3 = new User("user3", "3", "3", "3", "3");
            Console.WriteLine("user1.ToString() : " + user1.ToString());
            user1.print();

            Console.WriteLine("---Product---");
            Product product1 = new Product("prod1", "prod1 description",1);
            Console.WriteLine("product1.ToString() : " + product1.ToString());
            product1.print();
            Product product2 = new Product("prod2", "prod2 description", 1);
            //Product product3 = new Product("prod3", "prod3 description", 1);
            DiscountProduct discount_product1 = new DiscountProduct("prod3", "prod3 description", 200,50);
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

            //

        }
    }
}
