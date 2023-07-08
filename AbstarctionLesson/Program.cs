using AbstarctionLesson;

internal class Program
{
    private static void Main(string[] args)
    {

        Winter winter = new Winter();
        Spring spring = new Spring();   
        Summer summer = new Summer();
        Season autumn = new Autumn();

        winter.Rain();
        winter.Snow();
        Console.WriteLine("111111");
        spring.Rain();
        spring.Snow();
        Console.WriteLine("2222222");
        summer.Rain();
        summer.Snow();
        Console.WriteLine("333333");
        autumn.Rain();
        autumn.Snow();

        Console.ReadKey();
    }
}