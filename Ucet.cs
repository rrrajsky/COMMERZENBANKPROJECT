using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Ucet
    {

        private int id;
        private string username;
        private string password;
        private TypUctu typUctu;


        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public TypUctu TypUctu { get; set; }

        public Ucet(int id, string username, string password, TypUctu typUctu)
        {
            this.id = id;
            this.username = username;
            this.password = password;
            this.typUctu = typUctu;
        }

        public Ucet()
        {
        }
    }
}
