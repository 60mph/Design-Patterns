using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorsProject.Beverages
{
    class GreenTea : BeverageBase
    {
        public GreenTea() {
            Descripion = "Green leaf tea";
        }
        public override double GetCost()
        {
            return 90;
        }
    }
}
