using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstarctionLesson
{
    abstract class Season
    {
        public abstract void Rain();
        public virtual void Snow()
        {
            Console.WriteLine("Abstract class Snow");
        }

        public virtual void Hail()
        {

        }
    }
}
