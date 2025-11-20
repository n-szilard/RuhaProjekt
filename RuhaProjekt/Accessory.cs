using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuhaProjekt
{
    public class Accessory : Clothing
    {


        public string Type { get; set; }
        public string Functionality { get; set; }
        public int Weight { get; set; }

        public Accessory(string brand, string size, string color, int price, string type, string functionality, int weight) : base(brand, size, color, price)
        {
            Type = type;
            Functionality = functionality;
            Weight = weight;
        }

        public override string GetClothingType()
        {
            return Type;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Márka: {Brand}, Méret: {Size}, Szín: {Color}, Ár: {Price} Ft, Típus: {Type}, Funkcionalitas: {Functionality}, Súly: {Weight} g");
        }
    }
}
