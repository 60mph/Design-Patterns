using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCommand.Reciver
{
    public class Tv
    {
        public void TurnOn()
        {
            Console.WriteLine("Tv включен");
            State = State.On;
        }
        public void TurnOff()
        {
            Console.WriteLine("Tv выключен");
            State = State.Off;
        }
        public State State { get; set; }
    }
}
