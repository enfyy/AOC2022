using AOC22.Misc;

namespace AOC22.Days;

[Day(1)]
public class Day1 : IDailyPuzzle
{
    public void Run(IEnumerable<string> inputLines)
    {
        var text = string.Join(" ", inputLines);
        Console.WriteLine(text);
    }
}