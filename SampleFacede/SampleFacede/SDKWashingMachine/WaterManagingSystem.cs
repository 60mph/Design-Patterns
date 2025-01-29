using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFacade.WashingMachine
{
    public class WaterManagingSystem
    {
        public void FillWater(int liters)
        {
            Console.WriteLine("Fill with {0} liters of water", liters);
        }

        public void EmptyWater()
        {
            Console.WriteLine("Empty water tank");
        }
    }
}
