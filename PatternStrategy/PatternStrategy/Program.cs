using PatternStrategy.Duck;

internal class Program
{
    private static void Main(string[] args)
    {
        SimpleDuck Sduck = new SimpleDuck();
        ExoticDuck Educk = new ExoticDuck();
        List<DuckBase> duckBases = new List<DuckBase>();
        duckBases.Add(Sduck);
        duckBases.Add(Educk);
        foreach (DuckBase d in duckBases)
        {
            d.Display();
            d.flyable.Fly();
            d.quackable.Quack();
        }
    }
}