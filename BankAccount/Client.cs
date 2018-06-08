using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Client
    {
        //properties
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        //constructors
        public Client()
        {
            //default
        }
        public Client(string name, string phonenumber, string address)
        {
            this.Name = name;
            this.PhoneNumber = phonenumber;
            this.Address = address;
        }

        //method
        public void GetClient()
        {
            
        }

    }
}
