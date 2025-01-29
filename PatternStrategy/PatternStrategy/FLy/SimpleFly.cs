using PatternStrategy.FLy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternStrategy.Duck.FLy
{
    public class SimpleFly : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("I can fly!!!");
        }
    }
}
