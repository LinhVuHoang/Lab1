using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Models
{
    class User
    {
        private string email;
        private string tieude;
        private string noidung;
        public User(string email, string tieude,string noidung)
        {
            Email = email;
            Tieude = tieude;
            Noidung = noidung;
        }
        public string Email //properties
        {
            get => email;
            set => email= value;
        }
        public string Tieude
        {
            get => tieude;
            set => tieude = value;
        }
        public string Noidung
        {
            get => noidung;
            set => noidung = value;
        }
    }
}
