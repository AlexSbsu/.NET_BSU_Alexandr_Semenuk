using System;
namespace Study_HomeWork_7
{
    public class User
    {
        public static int User_gid = 1;
        readonly private int id;
        private string name = "name" + User_gid.ToString();
        private string surname = "surname" + User_gid.ToString();
        private string patrname = "patrname" + User_gid.ToString();
        private string tel;
        private string address = "address" + User_gid.ToString();

        public int Id { get => id; }
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
            protected set { if (!string.IsNullOrEmpty(value)) tel = value; }
        }
        public string Address { get => address; protected set => address = value; }

        //---Constructor
        public User(string nname, string ssurname, string ppatrname, string ttel, string aaddress)
        {
            id = User_gid;
            name = nname;
            surname = ssurname;
            patrname = ppatrname;
            tel = ttel;
            address = aaddress;
            User_gid++;
        }

        public override string ToString()
        {
            return ("id=" + this.id 
                + " Name=" + this.name
                + " Surname=" + this.surname
                + " Patrname=" + this.patrname
                + " Phone = " + this.tel
                + " Address = " + this.address);
        }
        public void print()
        {
            Console.WriteLine("id = " + this.id);
            Console.WriteLine("Name = " + this.name);
            Console.WriteLine("Surname = " + this.surname);
            Console.WriteLine("Patrname = " + this.patrname);
            Console.WriteLine("Phone = " + this.tel);
            Console.WriteLine("Address = " + this.address);
        }
    }
}
