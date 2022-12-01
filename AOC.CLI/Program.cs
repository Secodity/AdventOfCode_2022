using AOC.CLI.DayOne;

namespace AOC.CLI;

internal class Program
{
    static void Main(string[] args)
    {
        new DayOneSolution().Solve();
        Console.Write("Press any key to continue...");
        Console.ReadKey();
    }
}
