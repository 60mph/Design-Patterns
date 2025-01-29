using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternStrategy.Duck.FLy;
using PatternStrategy.FLy;
using PatternStrategy.Quack;

namespace PatternStrategy.Duck
{
    public abstract class DuckBase
    {
        public IFlyable flyable;
        public IQuackable quackable;

        protected DuckBase()
        {
            flyable = new SimpleFly();
            quackable = new SimpleQuack();
        }

        public abstract void Display();
    }
}
