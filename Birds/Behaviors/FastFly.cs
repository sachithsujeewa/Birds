using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birds.Behaviors
{

    public class FastFly : IFly
    {
        public void wayOfFly()
        {
            Console.WriteLine("I can't fly fast");
        }
    }
}
