using SampleCommand.Reciver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCommand.Command
{
    public class TeapotCommand : ICommand
    {
        private Teapot teapot;

        public TeapotCommand(Teapot teapot)
        {
            this.teapot = teapot;
        }
        public void Execute()
        {
            teapot.TurnOn();
        }

        public void Undo()
        {
            teapot.TurnOff();
        }

        public override string? ToString()
        {
            return "Включить чайник";
        }
    }
}
