using SampleCommand.Reciver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCommand.Command
{
    public class TvCommand : ICommand
    {
        private Tv tv;

        public TvCommand(Tv tv) {
        this.tv = tv;
        }
        public void Execute()
        {
            tv.TurnOn();
        }

        public void Undo()
        {
            tv.TurnOff();
        }

        public override string? ToString()
        {
            return "Включить телевизор";
        }
    }
}
