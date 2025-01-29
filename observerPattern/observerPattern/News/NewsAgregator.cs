using observerPattern.Subsribers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observerPattern.News
{
    public class NewsAgregator : ISubject
    {
        private List <IObserver> _observers;
        private static Random _random;

        public string GetTwitterNews()
        {
            var news = new List<string>
            {
                "Новость из X 1", "Новость из X 2", "Новость из X 3"
            };
            return news[_random.Next(3)];
        }

        public string GetLentaNews()
        {
            var news = new List<string>
            {
                "Новость из Lenta 1", "Новость из Lenta 2", "Новость из Lenta 3"
            };
            return news[_random.Next(3)];
        }

        public string GetTvNews()
        {
            var news = new List<string>
            {
                "Новость из Tv 1", "Новость из Tv 2", "Новость из Tv 3"
            };
            return news[_random.Next(3)];
        }
        public NewsAgregator()
        {
            _observers = new List <IObserver>();
            _random = new Random();
        }

        public void NotifyObserver()
        {
            string tv = GetTvNews();
            string twitter = GetTwitterNews();
            string lenta = GetLentaNews();

            foreach (var observer in _observers)
            {
                observer.Update(twitter, lenta, tv);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NewNewsAvailable()
        {
            NotifyObserver();
        }
    }
}
