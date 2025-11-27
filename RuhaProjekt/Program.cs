using System;
using System.Collections.Generic;

namespace RuhaProjekt
{
    internal class Program
    {
        static List<Clothing> ruhak = new List<Clothing>();
        public const string fajlNev = "ruhak.txt";

        static void Main(string[] args)
        {
            // Betöltés fájlból, ha létezik
            if (File.Exists(fajlNev))
            {
                ruhak = FileHelper.Read(fajlNev, false);
            }

            // Menü indítása
            Menu menu = new Menu(ruhak);
            menu.Start();
        }
    }
}
