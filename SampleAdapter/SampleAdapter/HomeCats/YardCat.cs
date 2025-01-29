using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleAdapter.HomeCats
{
    class YardCat : IHomeCat
    {
        public string Name { get; set; }

        public void Meow()
        {
            Console.Write("*Мяучит\n");
        }

        public void Scratch()
        {
            Console.Write("- 20 HP\n");
        }
    }
}
