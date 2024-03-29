using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Transakce v = new Transakce();
            bool chciOdejit = true;
            while (chciOdejit)
            {
                Console.WriteLine("Dobrý den, copak by jste dnes chtěl provésti");
                Console.WriteLine("1.Vytvorit:");
                Console.WriteLine("2.Prevest:");
                Console.WriteLine("3.Vlozit:");
                Console.WriteLine("4.Vybrat:");
                Console.WriteLine("5.Odejit");
                string volba = Console.ReadLine();
                switch (volba)
                {
                    case "Vytvorit":
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

                        Ucet u = new Ucet(id, userName, password, Balanace, typ);
                        Console.WriteLine(u);
                        long timestamp = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
                        string filepath = $"ucet" + id + ".json";
                        u.SaveToJson(filepath);
                        break;
                    case "Prevest":
                        Console.WriteLine("Prevod z uctu:");
                        int zuctu = Convert.ToInt32(Console.ReadLine());
                        string filepath1 = $"ucet" + zuctu + ".json";
                        Ucet u3 = Ucet.ReadFromJson(filepath1);
                        Console.WriteLine("Prevod na ucet:");
                        int docutu = Convert.ToInt32(Console.ReadLine());
                        string filepath2 = $"ucet" + docutu + ".json";
                        Ucet u4 = Ucet.ReadFromJson(filepath2);
                        Console.WriteLine("Kolik:");
                        int kolik = Convert.ToInt32(Console.ReadLine());
                        v.Prevod(u3, u4, kolik);
                        Console.WriteLine(u3);
                        Console.WriteLine(u4);
                        u3.SaveToJson(filepath1);
                        u4.SaveToJson(filepath2);
                        break;
                    case "Vlozit":
                        Console.WriteLine("Vklad na ucet:");
                        int douctu = Convert.ToInt32(Console.ReadLine());
                        string filepath3 = $"ucet" + douctu + ".json";
                        Ucet u5 = Ucet.ReadFromJson(filepath3);
                        Console.WriteLine("Kolik:");
                        int kolko = Convert.ToInt32(Console.ReadLine());
                        v.vlozte(u5, kolko);
                        u5.SaveToJson(filepath3);
                        break;
                    case "Vybrat":
                        Console.WriteLine("Vybrat z uctu:");
                        int zouctu = Convert.ToInt32(Console.ReadLine());
                        string filepath4 = $"ucet" + zouctu + ".json";
                        Ucet u6 = Ucet.ReadFromJson(filepath4);
                        Console.WriteLine("Kolik:");
                        int kolikos = Convert.ToInt32(Console.ReadLine());
                        v.vyber(u6, kolikos);
                        u6.SaveToJson(filepath4);
                        break;
                    case "Odejit":
                        Console.WriteLine("Nashledanou.");
                        chciOdejit = false;
                        break;
                    default:
                        Console.WriteLine("Spatny vyber");
                        break;
                }
            }
            
        }
    }
}
