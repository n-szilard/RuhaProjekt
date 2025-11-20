using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuhaProjekt
{
    abstract class TopWear : Clothing
    {


        public string Type { get; set; }
        public string Fit { get; set; }
        public string Neckline { get; set; }
        protected TopWear(string brand, string size, string color, int price, string type, string fit, string neckline) : base(brand, size, color, price)
        {
            Type = type;
            Fit = fit;
            Neckline = neckline;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Márka: {Brand}, Méret: {Size}, Szín: {Color}, Ár: {Price} Ft, Típus: {Type}, Fit: {Fit}, Nyakvonal: {Neckline}");
        }

        public override string GetClothingType()
        {
            return Type;
        }

    }
}
