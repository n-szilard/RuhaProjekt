using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuhaProjekt
{
    public class BottomWear : Clothing
    {

        public string Type { get; set; }
        public string Material { get; set; }
        public int Length { get; set; }
        public BottomWear(string brand, string size, string color, int price, string material, int length, string type) : base(brand, size, color, price)
        {
            Type = type;
            Material = material;
            Length = length;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Márka: {Brand}, Méret: {Size}, Szín: {Color}, Ár: {Price} Ft, Típus: {Type}, Anyag: {Material}, Hossz: {Length} cm");
        }

        public override string GetClothingType()
        {
            return Type;
        }
    }
}
