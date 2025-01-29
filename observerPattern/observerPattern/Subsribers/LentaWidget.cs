using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observerPattern.Subsribers
{
    public class LentaWidget:IObserver
    {
        private string _lenta;
        public void Display()
        {
            Console.WriteLine("Lenta: {0}", _lenta);
        }

        public void Update(string twitterX, string lenta, string tv)
        {
            if (!string.IsNullOrEmpty(lenta))
            {
                _lenta = lenta;
                Display();
            }
        }
    }
}
