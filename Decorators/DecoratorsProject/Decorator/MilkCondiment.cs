using DecoratorsProject.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorsProject.Decorator
{
    class MilkCondiment : CondimentDecoratorBase
    {
        private const int COST_MILK = 40;
        BeverageBase _beverage;
        public MilkCondiment(BeverageBase beverage)
        {
            this._beverage = beverage;
            Descripion = _beverage.GetDescriptoin() + " + Milk";
        }
        public override double GetCost()
        {
            return _beverage.GetCost() + COST_MILK;
        }
    }
}
