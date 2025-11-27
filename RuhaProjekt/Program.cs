using RuhaProjekt;

internal class Program
{
    static List<Clothing> ruhak = new List<Clothing>();

    private static void Main(string[] args)
    {
        bool fut = true;

        while (fut)
        {
            Console.Clear();
            Console.WriteLine("******* RUHA PROJEKT MENÜ *******");
            Console.WriteLine("1 - Új kiegészítő hozzáadása");
            Console.WriteLine("2 - Összes ruha listázása");
            Console.WriteLine("3 - Kilépés");
            Console.WriteLine("*********************************");
            Console.Write("Válassz egy menüpontot: ");
            string valaszt = Console.ReadLine()!;

            switch (valaszt)
            {
                case "1":
                    UjKiegeszito();
                    break;

                case "2":
                    Listazas();
                    break;

                case "3":
                    fut = false;
                    break;

                default:
                    Console.WriteLine("Érvénytelen választás!");
                    Console.ReadLine();
                    break;
            }
        }
    }

    static void UjKiegeszito()
    {
        Console.Clear();
        Console.WriteLine("--- Új kiegészítő hozzáadása ---");

        Console.Write("Márka: ");
        string brand = Console.ReadLine()!;

        Console.Write("Méret: ");
        string size = Console.ReadLine()!;

        Console.Write("Szín: ");
        string color = Console.ReadLine()!;

        Console.Write("Ár: ");
        int price = int.Parse(Console.ReadLine()!);

        Console.Write("Kategória: ");
        string category = Console.ReadLine()!;

        Console.Write("Leírás: ");
        string desc = Console.ReadLine()!;

        Console.Write("Súly (g): ");
        int weight = int.Parse(Console.ReadLine()!);

        Accessory acc = new Accessory(brand, size, color, price, category, desc, weight);
        ruhak.Add(acc);

        Console.WriteLine("\nKiegészítő sikeresen hozzáadva!");
        Console.ReadLine();
    }

    static void Listazas()
    {
        Console.Clear();
        Console.WriteLine("--- Összes ruha listája ---\n");

        if (ruhak.Count == 0)
        {
            Console.WriteLine("Nincs még ruha a listában.");
        }
        else
        {
            foreach (var r in ruhak)
            {
                Console.WriteLine($"{r.GetClothingType()}:");
                r.DisplayInfo();
                Console.WriteLine();
            }
        }

        Console.WriteLine("ENTER a folytatáshoz...");
        Console.ReadLine();
    }
}
