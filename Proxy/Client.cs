﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class Client : IClient
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public Client(string name, string phone, string address)
        {
            Name = name;
            Phone = phone;
            Address = address;
        }

        public Client()
        {
        }

        public Client(string phone)
        {
            Phone = phone;
        }

        public Client GetClient(string name, string phone, string address)
        {
            if (Name == null || Address == null)
            {
                
            }
            ClientProxy.Clients.Add(this);
            return this;
        }
    }
}
