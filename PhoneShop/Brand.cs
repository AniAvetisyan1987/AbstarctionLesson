namespace PhoneShop
{
    abstract class Brand
    {
        public abstract void Phone();

        public virtual void Planshet()
        {
            Console.WriteLine("Brand Planshet");
        }

        public virtual void EarPods()
        {
            Console.WriteLine("Brand EarPods");
        }

        public abstract string PowerBank { get; }
    }
}
