using RuhaProjekt;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Accessory acc = new Accessory("1string", "2string", "3string", 4, "5string", "6string", 7);
        TopWear top = new TopWear("1string", "2string", "3string", 4, "5string", "6string", "7string");
        BottomWear bottom = new BottomWear("1string", "2string", "3string", 4, "5string", "6string", 7);

        List<Clothing> lista = new List<Clothing>();
        lista.Add(acc);
        lista.Add(top);
        lista.Add(bottom);

        FileHelper.Write("ruha.txt", lista, "");

        List<Clothing> beolvasott = FileHelper.Read("ruha.txt", false);
        foreach (Clothing c in beolvasott)
        {
            c.DisplayInfo();
        }

    }
}