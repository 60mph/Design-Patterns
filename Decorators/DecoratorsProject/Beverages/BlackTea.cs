using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorsProject.Beverages
{
    internal class BlackTea : BeverageBase
    {
        public BlackTea() {
            Descripion = "Strong black leaf tea";
        }
        public override double GetCost()
        {
            return 70;
        }
    }
}
