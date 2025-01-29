using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternStrategy.Quack
{
    public class SimpleQuack : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("I can Quack");
        }
    }
}
