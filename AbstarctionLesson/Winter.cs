using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstarctionLesson
{
    internal class Winter : Season
    {
        public override void Rain()
        {
            Console.WriteLine("Winter Rain class");
        }

        public override void Snow()
        {
            Console.WriteLine("WInter class Snow");
        }

        public override void Hail()
        {
            Console.WriteLine("Winter class Hail");
        }
    }
}
