﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Models
{
    class ContactList
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public ContactList(string name, string phone)
        {
            Name = name;
            Phone = phone;
        }
    }
}
