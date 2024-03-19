using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Vklad
    {
        private int ID; 
        

        public Vklad(int id) {
            this.ID = id;
        }
        public Vklad() { 
        this.ID = 0;
        }
       
        public Ucet vlozte(Ucet u1, int vloz)
        {
            u1.Balance = u1.Balance + vloz;
            return u1;
        }
        public Ucet vyber(Ucet u1, int vyber)
        {
            u1.Balance = u1.Balance - vyber;
            return u1;
        }
        public Ucet Prevod(Ucet u1 , Ucet u2, int prevod)
        {
            u2.Balance -= prevod;
            u1.Balance += prevod;
            return u1;
        }
    }
}
