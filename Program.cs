using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Vklad v = new Vklad();
            Console.WriteLine("Dobrý den, copak by jste dnes chtěl provésti");
            Console.WriteLine("1.Vytvoreni Uzivatele:");
            Console.WriteLine("2.Prevod:");
            Console.WriteLine("3.Vklad:");
            Console.WriteLine("4.Vyber:");
            int age = Convert.ToInt32(Console.ReadLine());
            switch (age)
            {
                case 1:
                    Console.WriteLine("Id:");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Username:");
                    string userName = Console.ReadLine();
                    Console.WriteLine("Password:");
                    string password = Console.ReadLine();
                    Console.WriteLine("Balance:");
                    int Balanace = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Typ uctu:");
                    string typ = Console.ReadLine();
                    
                    Ucet u = new Ucet(id,userName,password,Balanace,typ);
                    Console.WriteLine(u);
                    long timestamp = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
                    string filepath = $"ucet" + id + ".json";
                    u.SaveToJson(filepath);
                    break;
                case 2:
                    Console.WriteLine("Prevod z uctu:");
                    int zuctu = Convert.ToInt32(Console.ReadLine());
                    Ucet u3 = new Ucet();
                    Console.WriteLine("Prevod na ucet:");
                    int docutu = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Kolik:");
                    int kolik = Convert.ToInt32(Console.ReadLine());
                    v.Prevod(zuctu, docutu,kolik);

                    break;
                default:
                    Console.WriteLine("Spatny vyber");
                    break;
            }
        }
    }
}
