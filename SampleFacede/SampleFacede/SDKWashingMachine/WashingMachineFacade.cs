using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFacade.WashingMachine
{
    class WashingMachineFacade
    {
        private Dryer dryer;
        private Engine engine;
        private Thermo thermo;
        private WaterManagingSystem waterSystem;

        public WashingMachineFacade()
        {
            dryer = new Dryer();
            engine = new Engine();
            thermo = new Thermo();
            waterSystem = new WaterManagingSystem();
        }

        public int GetTemerature()
        {
            return thermo.GetTemperatue();
        }

        public void WashCotton() 
        {
            waterSystem.FillWater(10);
            thermo.WarmUp(60);
            engine.Rotate();
            Console.WriteLine("Timeout 30min");
            engine.Stop();
            waterSystem.EmptyWater();
            waterSystem.FillWater(15);
            thermo.WarmUp(40);
            engine.Rotate();
            Console.WriteLine("Timeout 30min");
            engine.Stop();
            waterSystem.EmptyWater();
            dryer.Dry(30, 1000);
        }

        public void WashWool()
        {
            waterSystem.FillWater(7);
            thermo.WarmUp(30);
            engine.Rotate();
            Console.WriteLine("Timeout 30min");
            engine.Stop();
            waterSystem.EmptyWater();
            waterSystem.FillWater(10);
            thermo.WarmUp(10);
            engine.Rotate();
            Console.WriteLine("Timeout 30min");
            engine.Stop();
            waterSystem.EmptyWater();
            dryer.Dry(60, 500);
        }
    }
}
