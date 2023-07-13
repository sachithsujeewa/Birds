using Birds.Behaviors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birds.Birds
{
    public class Eagle : Bird
    {
        public Eagle()
        {
            base.Fly = new FastFly();
        }
    }
}
