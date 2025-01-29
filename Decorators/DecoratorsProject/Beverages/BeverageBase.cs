using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorsProject.Beverages
{
    public abstract class BeverageBase
    {
        protected string Descripion = "";
        public string GetDescriptoin()
        {
            return Descripion;
        }
        public abstract double GetCost();
    }
}
