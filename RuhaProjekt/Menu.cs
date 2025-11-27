using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuhaProjekt
{
    public class Menu
    {
        private List<Clothing> ruhak;

        public Menu(List<Clothing> ruhakList)
        {
            ruhak = ruhakList;
        }

        public void Start()
        {
            int valasztas;
            do
            {
                Console.WriteLine("\n===== RUHA MENÜ =====");
                Console.WriteLine("1. Új felsőruházat hozzáadása");
                Console.WriteLine("2. Új alsóruházat hozzáadása");
                Console.WriteLine("3. Új kiegészítő hozzáadása");
                Console.WriteLine("4. Összes ruha listázása");
                Console.WriteLine("5. Ruhák törlése");
                Console.WriteLine("0. Kilépés");
                Console.Write("Választás: ");

                bool ervenyes = int.TryParse(Console.ReadLine(), out valasztas);
                Console.WriteLine();

                if (!ervenyes)
                {
                    Console.WriteLine("Érvénytelen választás");
                    valasztas = -1;
                    continue;
                }

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
                    case 5:
                        DeleteClothes();
                        break;
                    case 0:
                        FileHelper.Write("ruhak.txt", ruhak, "");
                        Console.WriteLine("Kilépés a menüből.");
                        break;
                    default:
                        Console.WriteLine("Érvénytelen választás!");
                        break;
                }

            } while (valasztas != 0);
        }

        private void DeleteClothes()
        {
            for (int i = 0; i < ruhak.Count; i++)
            {
                Console.Write($"{i + 1}. ");
                ruhak[i].DisplayInfo();

            }

            int valasztas;
            do
            {
                Console.Write("Válaszd ki a törölni kívánt ruha sorszámát (0 - Vissza): ");
                bool ervenyes = int.TryParse(Console.ReadLine(), out valasztas);

                if (!ervenyes)
                {
                    Console.WriteLine("Érvénytelen választás");
                    valasztas = -1;
                    continue;
                }

                if (valasztas != 0)
                {
                    ruhak.RemoveAt(valasztas - 1);
                }
            }
            while (valasztas != 0);

        }

        private void AddTopWear()
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

        private void AddBottomWear()
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

            ruhak.Add(new BottomWear(brand, size, color, price, type, material, length));
            Console.WriteLine("Alsóruházat hozzáadva!");
        }

        private void AddAccessory()
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

        private void ListClothes()
        {
            if (ruhak.Count == 0)
            {
                Console.WriteLine("Nincs egy ruha sem a listában.");
                return;
            }

            Console.WriteLine("=== RUHÁK LISTÁJA ===");
            foreach (var ruha in ruhak)
            {
                ruha.DisplayInfo();
            }
        }

    }
}
