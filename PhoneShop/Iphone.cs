using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneShop
{
    internal class Iphone : Brand, IColorInterface1
    {
        public string Color => "IPHOne is gold";

        public string Shape => "Iphone shape";
        public override void Phone()
        {
            Console.WriteLine("Iphone Planshet");
        }

        public override void EarPods()
        {
            Console.WriteLine("Iphone EarPods");
        }

        public override string PowerBank => "Iphone powerbank";
    }
}
