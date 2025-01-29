using DecoratorsProject.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorsProject.Decorator
{
    class ChocolateCondiment : CondimentDecoratorBase
    {
        private const int COST_CHOCOLATE = 70;
        BeverageBase _beverage;
        public ChocolateCondiment(BeverageBase beverage)
        {
            this._beverage = beverage;
            Descripion = _beverage.GetDescriptoin() + " + Chocolate";
        }
        public override double GetCost()
        {
            return _beverage.GetCost() + COST_CHOCOLATE;
        }
    }
}
