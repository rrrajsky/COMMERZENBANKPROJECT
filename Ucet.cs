using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Ucet
    {

        private int id;
        private string username;
        private string password;
        private int balance;
        private string typUctu;


        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Balance { get; set; }
        public string TypUctu { get; set; }

        public Ucet(int id, string username, string password, int balance,string typUctu)
        {
            this.id = id;
            this.username = username;
            this.password = password;
            this.balance = balance;
            this.typUctu = typUctu;
        }

        public Ucet()
        {
        }

        public override string? ToString()
        {
            return username + ", password: " + password + ", balance: " + balance + ", typ uctu: " + typUctu;
        }
        
    }
}
