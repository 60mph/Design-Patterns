using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleTemplate.FastFood
{
    class Hamburger : FastFood
    {
        public override void AddTopings()
        {
            Console.WriteLine("1000 ost");
        }

        public override void PrepareMainIngridient()
        {
            Console.WriteLine("Meat");
        }
    }
}
