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

                if (valasztas != 0 && valasztas >= 1 && (valasztas-1) < ruhak.Count)
                {
                    ruhak.RemoveAt(valasztas - 1);
                    Console.WriteLine($"{valasztas}. ruha törölve!");
                }
            }
            while (valasztas != 0);

        }

        private void AddTopWear()
        {
            string brand = PromptNonEmpty("Márka: ");
            string size = PromptNonEmpty("Méret: ");
            string color = PromptNonEmpty("Szín: ");
            int price = PromptInt("Ár: ");
            string type = PromptNonEmpty("Típus: ");
            string fit = PromptNonEmpty("Fit: ");
            string neckline = PromptNonEmpty("Nyakvonal: ");

            ruhak.Add(new TopWear(brand, size, color, price, type, fit, neckline));
            Console.WriteLine("Felsőruházat hozzáadva!");
        }

        private void AddBottomWear()
        {
            string brand = PromptNonEmpty("Márka: ");
            string size = PromptNonEmpty("Méret: ");
            string color = PromptNonEmpty("Szín: ");
            int price = PromptInt("Ár: ");
            string material = PromptNonEmpty("Anyag: ");
            int length = PromptInt("Hossz (cm): ");
            string type = PromptNonEmpty("Típus: ");

            ruhak.Add(new BottomWear(brand, size, color, price, type, material, length));
            Console.WriteLine("Alsóruházat hozzáadva!");
        }

        private void AddAccessory()
        {
            string brand = PromptNonEmpty("Márka: ");
            string size = PromptNonEmpty("Méret: ");
            string color = PromptNonEmpty("Szín: ");
            int price = PromptInt("Ár: ");
            string type = PromptNonEmpty("Típus: ");
            string func = PromptNonEmpty("Funkció: ");
            int weight = PromptInt("Súly (g): ");

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

        private string PromptNonEmpty(string message)
        {
            string input;
            do
            {
                Console.Write(message);
                input = Console.ReadLine()?.Trim();
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Ez a mező nem lehet üres. Kérlek, adj meg értéket!");
                }
            } while (string.IsNullOrEmpty(input));
            return input;
        }

        private int PromptInt(string message)
        {
            int result;
            string input;
            do
            {
                Console.Write(message);
                input = Console.ReadLine()?.Trim();
                if (!int.TryParse(input, out result))
                {
                    Console.WriteLine("Érvénytelen szám! Kérlek, adj meg egy egész számot.");
                }
                else if (result < 0)
                {
                    Console.WriteLine("A szám nem lehet negatív! Adj meg egy 0 vagy nagyobb értéket.");
                }
            }
            while (!int.TryParse(input, out result) || result < 0);
            return result;
        }

    }
}
