using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternStrategy.FLy
{
    public class NoFly : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly");
        }
    }
}
