using System;
namespace Study_HomeWork_8
{
    public class User:BaseModel
    {
        //public static int User_gid = 1;
        //readonly private int id;
        private string name;// = "name" +  Id.ToString();
        private string surname;// = "surname" + User_gid.ToString();
        private string patrname;// = "patrname" + User_gid.ToString();
        private string tel;
        private string address;// = "address" + User_gid.ToString();

        //public int Id { get => id; }
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
                if (!string.IsNullOrEmpty(value)
                    && PhoneHelper.IsPhoneValid(value))
                    tel = value;
                else Console.WriteLine($"!!!!!Invalid phone format for User {name}!!!!");
            }
        }
        public string Address { get => address; protected set => address = value; }

        //---Constructor
        public User(string nname, string ttel)
        {
            //id = User_gid;
            name = nname;
            surname = "NOT ENTERED";
            patrname = "NOT ENTERED";
            Tel = ttel;
            address = "NOT ENTERED";
            //User_gid++;
        }
        public User(string nname, string ssurname, string ppatrname, string ttel, string aaddress)
        {
            //id = User_gid;
            name = nname;
            surname = ssurname;
            patrname = ppatrname;
            Tel = ttel;
            address = aaddress;
            //User_gid++;
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
