using PatternStrategy.FLy;
using PatternStrategy.Quack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternStrategy.Duck
{
    public class ExoticDuck : DuckBase
    {
        public ExoticDuck()
        {
            this.flyable = new NoFly();
            this.quackable = new ExoticQuack();
        }

        public override void Display()
        {
            Console.WriteLine("I'm exotic duck");
        }
    }
}
