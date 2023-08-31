using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Study_HomeWork_10
{
    class MainClass
    {
        public static void Main()
        {       
            IUpdatedDatabase meDB1 = DBCreator.CreateUpdatedDatabase();
                       
            var userlist = meDB1.users.GetItems();
            var prodlist = meDB1.products.GetItems();
            var orderlist = meDB1.orders.GetItems();

            string uname, utel;
            string pname, pcost;
            string oname, r;

            if (File.Exists("testfile.txt")) File.WriteAllText("testfile.txt", "Hello from File");            
            else
            {
                File.Create("testfile.txt");
                File.WriteAllText("testfile.txt", "Hello");
            }

            FileInfo file = new FileInfo("testfile_FileStream.txt");
            using (FileStream fs = file.Open(FileMode.Create))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine("Hello from StreamWriter");
                }                    
            }
            Console.WriteLine(File.ReadAllText("testfile.txt"));
            Console.WriteLine(File.ReadAllText("testfile_FileStream.txt"));

            //var s2 = JsonConvert.SerializeObject(file);
            //FileInfo file2 = JsonConvert.DeserializeObject<FileInfo>(s2);
            //Console.WriteLine(s2);

            while (true)
            {
                Console.WriteLine("Select option:");
                Console.WriteLine("1.List Users");
                Console.WriteLine("11.Add user");
                Console.WriteLine("2.List Products");
                Console.WriteLine("21.Add Products");
                Console.WriteLine("3.List Orders");
                Console.WriteLine("31.List Orders");
                Console.WriteLine("8.Save DB to file");
                Console.WriteLine("9.Restore DB from file");
                Console.WriteLine("0.Exit");
                string s = Console.ReadLine();
                switch (s)
                {
                    case "1":
                        Console.Clear();
                        userlist = meDB1.users.GetItems();
                        foreach (User u in userlist) Console.WriteLine(u.ToString());
                        Console.WriteLine("\n");
                        break;
                    case "11":
                        Console.Clear();
                        Console.WriteLine("Enter user name:");
                        uname = Console.ReadLine();
                        Console.WriteLine("Enter phone in format : '+'12digits' like +123456789012");
                        utel = Console.ReadLine();
                        meDB1.users.AddItem(new User(uname, utel));
                        Console.WriteLine("\nPress Enter to continue");
                        break;
                    case "2":
                        Console.Clear();
                        prodlist = meDB1.products.GetItems();
                        foreach (Product p in prodlist) Console.WriteLine(p.ToString());
                        Console.WriteLine("\nPress Enter to continue");
                        break;
                    case "21":
                        Console.Clear();
                        Console.WriteLine("Enter product name:");
                        pname = Console.ReadLine();
                        Console.WriteLine("Enter cost:");
                        pcost = Console.ReadLine();
                        meDB1.products.AddItem(new Product(pname, "description", Convert.ToDouble(pcost)));
                        Console.WriteLine("\nPress Enter to continue");
                        break;
                    case "3":
                        Console.Clear();
                        orderlist = meDB1.orders.GetItems();
                        foreach (Order o in orderlist) Console.WriteLine(o.ToString());
                        Console.WriteLine("\nPress Enter to continue");
                        break;
                    case "31":
                        Console.Clear();                        
                        orderlist = meDB1.orders.GetItems();
                        foreach (Order o in orderlist) Console.WriteLine(o.ToString());
                        Console.WriteLine("\nPress Enter to continue");
                        break;
                    case "8":
                        Console.Clear();
                        meDB1.SaveDBToFile();                        
                        Console.WriteLine("\nPress Enter to continue");
                        break;
                    case "9":
                        Console.Clear();
                        meDB1.RestoreDBFromFile();
                        Console.WriteLine("\nPress Enter to continue");
                        break;
                    case "0":   //exit
                        meDB1.SaveDBToFile();
                        return;
                }
            }
        }
    }
}
