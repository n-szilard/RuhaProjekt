using System;
using System.Collections.Generic;

namespace RuhaProjekt
{
    internal class Program
    {
        static List<Clothing> ruhak = new List<Clothing>();

        static void Main(string[] args)
        {
            int valasztas;

            do
            {
                Console.WriteLine("\n===== RUHA MENÜ =====");
                Console.WriteLine("1. Új felsőruházat hozzáadása");
                Console.WriteLine("2. Új alsóruházat hozzáadása");
                Console.WriteLine("3. Új kiegészítő hozzáadása");
                Console.WriteLine("4. Összes ruha listázása");
                Console.WriteLine("0. Kilépés");
                Console.Write("Választás: ");

                int.TryParse(Console.ReadLine(), out valasztas);
                Console.WriteLine();

                switch (valasztas)
                {
                    case 1:
                        AddTopWear();
                        break;
                    case 2:
                        AddBottomWear();
                        break;
                    case 3:
                        AddAccessory();
                        break;
                    case 4:
                        ListClothes();
                        break;
                    case 0:
                        Console.WriteLine("Kilépés...");
                        break;
                    default:
                        Console.WriteLine("Érvénytelen választás!");
                        break;
                }

            } while (valasztas != 0);
        }

        // ----------- Felsőruházat hozzáadása ----------
        static void AddTopWear()
        {
            Console.Write("Márka: ");
            string brand = Console.ReadLine();
            Console.Write("Méret: ");
            string size = Console.ReadLine();
            Console.Write("Szín: ");
            string color = Console.ReadLine();
            Console.Write("Ár: ");
            int price = int.Parse(Console.ReadLine());
            Console.Write("Típus: ");
            string type = Console.ReadLine();
            Console.Write("Fit: ");
            string fit = Console.ReadLine();
            Console.Write("Nyakvonal: ");
            string neckline = Console.ReadLine();

            ruhak.Add(new TopWear(brand, size, color, price, type, fit, neckline));
            Console.WriteLine("Felsőruházat hozzáadva!");
        }

        // ----------- Alsóruházat ----------
        static void AddBottomWear()
        {
            Console.Write("Márka: ");
            string brand = Console.ReadLine();
            Console.Write("Méret: ");
            string size = Console.ReadLine();
            Console.Write("Szín: ");
            string color = Console.ReadLine();
            Console.Write("Ár: ");
            int price = int.Parse(Console.ReadLine());
            Console.Write("Anyag: ");
            string material = Console.ReadLine();
            Console.Write("Hossz (cm): ");
            int length = int.Parse(Console.ReadLine());
            Console.Write("Típus: ");
            string type = Console.ReadLine();

            ruhak.Add(new BottomWear(brand, size, color, price, material, length, type));
            Console.WriteLine("Alsóruházat hozzáadva!");
        }

        // ----------- Kiegészítő ----------
        static void AddAccessory()
        {
            Console.Write("Márka: ");
            string brand = Console.ReadLine();
            Console.Write("Méret: ");
            string size = Console.ReadLine();
            Console.Write("Szín: ");
            string color = Console.ReadLine();
            Console.Write("Ár: ");
            int price = int.Parse(Console.ReadLine());
            Console.Write("Típus: ");
            string type = Console.ReadLine();
            Console.Write("Funkció: ");
            string func = Console.ReadLine();
            Console.Write("Súly (g): ");
            int weight = int.Parse(Console.ReadLine());

            ruhak.Add(new Accessory(brand, size, color, price, type, func, weight));
            Console.WriteLine("Kiegészítő hozzáadva!");
        }

        // ----------- Listázás ----------
        static void ListClothes()
        {
            if (ruhak.Count == 0)
            {
                Console.WriteLine("Nincs egy ruha sem a listában.");
                return;
            }

        Console.WriteLine(acc.GetType().Name);
    }
}
