using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorsProject.Beverages
{
    internal class Espresso : BeverageBase
    {
        public Espresso() {
            Descripion = "Small portion of strong coffee";
        }

        public override double GetCost()
        {
            return 120;
        }
    }
}
