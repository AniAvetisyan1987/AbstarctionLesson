using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleInterfaces
{
    interface IHuman
    {
        string Name { get; }
        string Description { get; } 
        string GoToWork { get; }

        string Eat()
        {
            return "All food";
        }
    }
}
