using SampleAdapter.HomeCats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleAdapter
{
    class PrintCatInfo
    {
        public static void CatInfoPrint(IHomeCat cat)
        {
            Console.WriteLine("Досье кошки: ");
            Console.WriteLine("Имя кота: {0}", cat.Name);
            Console.WriteLine("Вид мяуканья: ");
            cat.Meow();
            Console.WriteLine("Урон: ");
            cat.Scratch();
            Console.WriteLine();
        }
    }
}
