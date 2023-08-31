using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_HomeWork_10
{
    static internal class DBCreator
    {
        public static IDBInterface CreateDatabase()
        {
            IDBInterface database = new InMemoryDatabase_fake();  //InMemoryDatabase_fake();
            return database;
        }
        public static IUpdatedDatabase CreateUpdatedDatabase()
        {
            IUpdatedDatabase database = new InMemoryDatabase();  //InMemoryDatabase_fake();
            return database;
        }
    }
}
