using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleAdapter.HomeCats
{
    class PedigreedCat : IHomeCat
    {
        public string Name { get; set; }

        public void Meow()
        {
            Console.Write("*Мурчание\n");
        }

        public void Scratch()
        {
            Console.Write("Отсутствует возможность. Когтей нет\n");
        }
    }
}
