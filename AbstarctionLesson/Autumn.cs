namespace AbstarctionLesson
{
    internal class Autumn : Season
    {
        public override void Rain()
        {
            Console.WriteLine("Autumn Rain class");
        }

        public override void Snow()
        {
            Console.WriteLine("Autumn class Snow");
        }

        public override void Hail()
        {
            Console.WriteLine("Autumn class Hail");
        }
    }
}
