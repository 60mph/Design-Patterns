using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observerPattern.Subsribers
{
    public class TvWidget : IObserver
    {
        private string _tv;
        public void Display()
        {
            Console.WriteLine("Tv: {0}", _tv);
        }

        public void Update(string twitterX, string lenta, string tv)
        {
            if (!string.IsNullOrEmpty(tv))
            {
                _tv = tv;
                Display();
            }
        }
    }
}
