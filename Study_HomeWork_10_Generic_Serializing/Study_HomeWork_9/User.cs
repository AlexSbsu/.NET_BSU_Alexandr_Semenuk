using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Study_HomeWork_10
{

    public class User : BaseModel
    {
        //public static int User_gid = 1;
        //readonly private int id;
        public string name;      // = "name" +  Id.ToString();
        public string surname;   // = "surname" + User_gid.ToString();
        public string patrname;  // = "patrname" + User_gid.ToString();
        public string tel;
        public string address;   // = "address" + User_gid.ToString();
        //public long id;
        //public long Id { get=>id;  }
        public string Name
        {
            get => name;
            protected set { if (!string.IsNullOrEmpty(value)) name = value; }
        }
        public string Surname
        {
            get => surname;
            protected set { if (!string.IsNullOrEmpty(value)) Surname = value; }
        }
        public string Patrname
        {
            get => patrname;
            protected set { if (!string.IsNullOrEmpty(value)) Surname = value; }
        }
        public string Tel
        {
            get => tel;
            protected set
            {
                tel = value;
                //if (!string.IsNullOrEmpty(value) && PhoneHelper.IsPhoneValid(value)) tel = value;
                //else  { Console.WriteLine($"!!!!!Invalid phone format for User {name}" + $" - created with default +123456789012 !!!!"); tel = "+123456789012";  }
            }
        }
        public string Address { get => address; protected set => address = value; }

        //---Constructor
        public User(string nname, string ttel)
        {
            //id = base.Id;
            name = nname;
            surname = "NOT ENTERED";
            patrname = "NOT ENTERED";
            Tel = ttel;
            address = "NOT ENTERED";
            //User_gid++;
        }
        public User(string nname, string ssurname, string ppatrname, string ttel, string aaddress)
        {
            //id = base.Id;
            name = nname;
            surname = ssurname;
            patrname = ppatrname;
            Tel = ttel;
            address = aaddress;
        }
        [JsonConstructor]
        public User(long id, string nname, string ssurname, string ppatrname, string ttel, string aaddress)
        {
            //this.id = id;
            name = nname;
            surname = ssurname;
            patrname = ppatrname;
            Tel = ttel;
            address = aaddress;            
        }
        public override string ToString()
            {
                return ("id=" + Id
                    + " Name=" + this.name
                    + " Surname=" + this.surname
                    + " Patrname=" + this.patrname
                    + " Phone = " + this.tel
                    + " Address = " + this.address);
            }
            public void print()
            {
                Console.WriteLine("User---> ");
                Console.WriteLine("id = " + Id);
                Console.WriteLine("Name = " + this.name);
                Console.WriteLine("Surname = " + this.surname);
                Console.WriteLine("Patrname = " + this.patrname);
                Console.WriteLine("Phone = " + this.tel);
                Console.WriteLine("Address = " + this.address);
            }
        }
    

}
