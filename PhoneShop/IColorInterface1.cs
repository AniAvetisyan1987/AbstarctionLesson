using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneShop
{
    internal interface IColorInterface1
    {
        string Color { get; }

        string Shape { get; }

        string IsMetalic()
        {
            return "Phone is metalic";
        }
    }
}
