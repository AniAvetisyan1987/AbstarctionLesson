using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstarctionLesson
{
    internal class Spring : Season
    {
        public override void Rain()
        {
            Console.WriteLine("Spring Rain class");
        }

        public override void Snow()
        {
            Console.WriteLine("Spring class Snow");
        }

        public override void Hail()
        {
            Console.WriteLine("Spring class Hail");
        }
    }
}
