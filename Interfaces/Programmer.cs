using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleInterfaces
{
    internal class Programmer : IHuman
    {
        public string Name { get; set; }


        public string Description { get; set; }

        public string GoToWork { get; set; }

        public string Eat()
        {
            return "Programmer eat";
        }

}
}
