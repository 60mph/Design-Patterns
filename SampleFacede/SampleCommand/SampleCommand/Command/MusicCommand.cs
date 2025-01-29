using SampleCommand.Reciver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCommand.Command
{
    public class MusicCommand : ICommand
    {
        private Music music;

        public MusicCommand(Music music)
        {
            this.music = music;
        }
        public void Execute()
        {
            music.TurnOn();
        }

        public void Undo()
        {
            music.TurnOff();
        }

        public override string? ToString()
        {
            return "Включить музыку";
        }
    }
}
