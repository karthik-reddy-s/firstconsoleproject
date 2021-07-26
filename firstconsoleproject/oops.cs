using System;
using System.Collections.Generic;
using System.Text;

namespace firstconsoleproject
{
      class user
    {
        //public static int a = 5;
        //static public void GetData() { Console.WriteLine("insidegetdata"); }
        //public int ID { get; set; }
        //public int Contact { get; set; }
        //public string Name { get; set; }
        //public DateTime DOB { get; set; }
        int id;string name;long contact;string place;DateTime dob;
        public user(int id, string name, long contact, string place, DateTime dob) { this.id = id;this.name = name;this.contact = contact;this.place = place;this.dob = dob; }
        public void GetUserName() { Console.WriteLine("username {0}", name); }
        public void GetID() { Console.WriteLine("ID {0}", id); }
        public void GetContact() { Console.WriteLine("contact {0}", contact); }
        public void GetPlace() { Console.WriteLine("place {0}", place); }
        public void GetDob() { Console.WriteLine("dob {0}", dob); }
    }
    
}
