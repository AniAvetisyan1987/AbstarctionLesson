using ExampleInterfaces;

internal class Program
{
    private static void Main(string[] args)
    {
        Programmer programmer = new Programmer();
        //programmer.Name = "Gago";
        //programmer.Description = "Hognac";
        //programmer.GoToWork = "Every day";
        Console.WriteLine(programmer.Eat());

        IHuman programmer1 = new Programmer();
        Console.WriteLine(programmer1.Eat());       

    }
}