using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFacade.WashingMachine
{
    public class Engine
    {
        public void Rotate()
        {
            Console.WriteLine("Start rotating");
        }
        public void Stop()
        {
            Console.WriteLine("Stop rotating");
        }
    }
}
