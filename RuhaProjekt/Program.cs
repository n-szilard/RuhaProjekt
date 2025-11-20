using RuhaProjekt;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Accessory acc = new Accessory("Fika", "M", "Fekete", 1241, "tipus", "dekorativ", 240);

        Console.WriteLine(acc.GetType().Name);
    }
}