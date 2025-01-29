using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observerPattern.Subsribers
{
    public interface IObserver
    {
        void Update(string twitterX, string lenta, string tv);
        void Display();
    }
}
