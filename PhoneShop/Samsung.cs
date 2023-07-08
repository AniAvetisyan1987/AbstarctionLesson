using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneShop
{
    internal class Samsung : Brand , IColorInterface1
    {
        public string Color => "Samsung is black";
        public string Shape => "Samsung shape is oval";

        public override void Phone()
        {
            Console.WriteLine("Samsung Planshet");
        }

        public override string PowerBank => "Samsung powerbank";
    }
}
