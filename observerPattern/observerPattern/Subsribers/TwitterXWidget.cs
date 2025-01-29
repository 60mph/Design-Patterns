using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observerPattern.Subsribers
{
    public class TwitterXWidget : IObserver
    {
        private string _twit;
        public void Display()
        {
            Console.WriteLine("TwitterX: {0}", _twit);
        }

        public void Update(string twitterX, string lenta, string tv)
        {
            if (!string.IsNullOrEmpty(twitterX))
            {
                _twit = twitterX;
                Display();
            }
        }
    }
}
