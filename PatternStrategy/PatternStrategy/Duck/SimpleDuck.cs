using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternStrategy.Duck
{
    public class SimpleDuck : DuckBase
    {
        public override void Display()
        {
            Console.WriteLine("I'm simple duck");
        }
    }
}
