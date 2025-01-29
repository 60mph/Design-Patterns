using DecoratorsProject.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorsProject.Decorator
{
    class SugarCondiment : CondimentDecoratorBase
    {
        //private const int COST_SUGAR = 20;
        BeverageBase _beverage;
        public SugarCondiment(BeverageBase beverage)
        {
            this._beverage = beverage;
            Descripion = _beverage.GetDescriptoin() + " + Sugar";
        }
        public override double GetCost()
        {
            return _beverage.GetCost(); //+ COST_SUGAR;
        }
    }
}
