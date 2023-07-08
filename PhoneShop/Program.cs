using PhoneShop;

internal class Program
{
    private static void Main(string[] args)
    {
        Samsung samsung = new Samsung();
        samsung.EarPods();
        Console.WriteLine(samsung.PowerBank);
        Console.WriteLine(samsung.Color);

        Iphone iphone = new Iphone();
        iphone.Phone();
        IColorInterface1 iPhone1 = new Iphone();
        Console.WriteLine(iPhone1.IsMetalic());
        Console.WriteLine(iphone.PowerBank);

        Motorola motorola = new Motorola();
        motorola.EarPods();
        Console.WriteLine(motorola.PowerBank);

        Console.ReadKey();
    }
}