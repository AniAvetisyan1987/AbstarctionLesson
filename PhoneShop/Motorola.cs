using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneShop
{
    internal class Motorola : Brand
    {
        public override void Phone()
        {
            Console.WriteLine("Motorola Planshet");
        }

        public override string PowerBank => "Motorola powerbank";
    }
}
