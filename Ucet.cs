using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace bankaprojekt
{

    internal class Ucet
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
            this.ID = id;
            this.Username = username;
            this.Password = password;
            this.Balance = balance;
            this.TypUctu = typUctu;
        }

        public Ucet()
        {
        }

        public override string? ToString()
        {
            return Username + ", password: " + Password + ", balance: " + Balance + ", typ uctu: " + TypUctu;
        }

        public void SaveToJson(string filePath)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            var jsonString = JsonSerializer.Serialize(this, options);
            File.WriteAllText(filePath, jsonString);
            
        }

     

    public static Ucet ReadFromJson(string filePath)
        {
            var jsonString = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<Ucet>(jsonString);
        }
    }

}

