using SampleCommand.Reciver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCommand.Command
{
    internal class LightCommand : ICommand
    {
        private readonly Light light;
        private Stack<LightState> states;

        public LightCommand(Light light)
        {
            this.light = light;
            this.states = new Stack<LightState>();
        }
        public void Execute()
        {
            states.Push(light.State);
            light.ToggleLight();
        }

        public void Undo()
        {
            var prevState = states.Pop();
            light.SetState(prevState);
        }

        public override string? ToString()
        {
            return "Изменить свет";
        }
    }
}
