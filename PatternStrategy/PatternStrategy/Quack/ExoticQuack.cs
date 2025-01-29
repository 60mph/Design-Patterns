using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternStrategy.Quack
{
    internal class ExoticQuack : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Meow!");
        }
    }
}
