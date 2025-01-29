using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCommand.Reciver
{
    public class Music
    {
        public void TurnOn()
        {
            Console.WriteLine("Музыка включен");
            State = State.On;
        }
        public void TurnOff()
        {
            Console.WriteLine("Музыка выключен");
            State = State.Off;
        }
        public State State { get; set; }
    }
}
