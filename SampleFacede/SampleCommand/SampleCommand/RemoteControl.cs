using SampleCommand.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCommand
{
    public class RemoteControl
    {
        private Dictionary<int, ICommand> commands;

        public RemoteControl() {
            commands = new Dictionary<int, ICommand>();
        }

        public void PushButton(int buttonId) {
            if (commands.ContainsKey(buttonId))
            {
                commands[buttonId].Execute();
            }
        }
        public void UndoButton(int buttonId) {
            if (commands.ContainsKey(buttonId))
            {
                commands[buttonId].Undo();
            }
        }

        public void SetCommandForButton(int buttonId, ICommand command)
        {
            commands[buttonId] = command;
        }

        public override string? ToString()
        {
            var strResult = new StringBuilder();
            foreach (var buttonId in commands.Keys) 
            {
                strResult.AppendFormat("{0} \t - {1} \n", buttonId, commands[buttonId]);
            }
            strResult.Append("проч. \t - Выход");
            return strResult.ToString();
        }
    }
}
