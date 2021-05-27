using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Models
{
    class MailList
    {
        public string Email { get; set; }
        
        public MailList(string email)
        {
            Email = email;
        }
    }
}
