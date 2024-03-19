using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dobrý den, copak by jste dnes chtěl provésti");
            Console.WriteLine("Vytvoreni Uzivatele:");
            Console.WriteLine("Prevod:");
            Console.WriteLine("Vklad:");
            Console.WriteLine("Vyber:");
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
                    string filepath = $"ucet" + timestamp + ".json";
                    u.SaveToJson(filepath);
                    break;
                case 2:
                   
                    break;
                default:
                    Console.WriteLine("Spatny vyber");
                    break;
            }
        }
    }
}
