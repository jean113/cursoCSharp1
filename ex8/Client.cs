using System;
using System.Globalization;

namespace ex8
{
    class Client
    {
        public string Name {get; set;}
        public string Email {get; set;}
        public DateTime Birth {get; set;}
       

        public Client(string name, string email, DateTime birth)
        {
            Name = name;
            Email = email;
            Birth = birth;
        }  

        public override string ToString()
        {
            return Name + "(" + Birth.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture) + ")" + " - " + Email;
        }
    }
}