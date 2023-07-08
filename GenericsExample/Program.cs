using GenericsExample;

internal class Program
{
    private static void Main(string[] args)
    {
        MyGeneric<string> myGeneric = new MyGeneric<string>();
        Console.WriteLine(myGeneric.GenericMethod(12,34));
        Console.WriteLine(myGeneric.GenericWithThreeParams(2, 3f, 12));
        Console.ReadKey();
    }
}