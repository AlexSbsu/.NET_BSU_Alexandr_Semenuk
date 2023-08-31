using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_HomeWork_10
{
    public interface IUpdatedDatabase
    {
        public  GenericSupport<User> users { get; }
        public  GenericSupport<Order> orders { get; }
        public  GenericSupport<Product> products { get; }

        public void SaveDBToFile();
        public void RestoreDBFromFile();
    }
}