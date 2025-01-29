using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFacade.WashingMachine
{
    public class Thermo
    {
        public int GetTemperatue()
        {
            return 50;
        }

        public void WarmUp(int degrees) 
        {
            Console.WriteLine("Warm for {0} degrees", degrees);
        }
    }
}
