using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleAdapter.WildCats
{
    class Tiger : IWildCat
    {
        public string Breed { get { return "Тигр"; } }

        public void Growl()
        {
            Console.Write("Раввв\n");
        }

        public void Scratch()
        {
            Console.Write("-100 HP\n");
        }
    }
}
