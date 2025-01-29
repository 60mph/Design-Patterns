using observerPattern.News;
using observerPattern.Subsribers;

internal class Program
{
    private static void Main(string[] args)
    {
        var publisher = new NewsAgregator();
        var subLenta = new LentaWidget();
        var subTwitter = new TwitterXWidget();
        var subTv = new TvWidget();

        publisher.RegisterObserver(subLenta);
        publisher.RegisterObserver(subTwitter);
        publisher.RegisterObserver(subTv);

        publisher.NewNewsAvailable();
        Console.WriteLine();

        publisher.NewNewsAvailable();
        Console.WriteLine();
    }
}