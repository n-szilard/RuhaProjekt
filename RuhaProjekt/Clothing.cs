using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuhaProjekt
{
    public abstract class Clothing
    {
        public string Brand { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public int Price { get; set; }

        protected Clothing(string brand, string size, string color, int price)
        {
            Brand = brand;
            Size = size;
            Color = color;
            Price = price;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Márka: {Brand}, Méret: {Size}, Szín: {Color}, Ár: {Price} Ft");
        }

        public abstract string GetClothingType();

    }
}
