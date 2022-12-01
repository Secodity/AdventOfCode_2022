using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC.CLI.DayOne;
public class DayOneSolution
{
    private readonly string PATH = Path.Combine(Environment.CurrentDirectory, "Inputs", "dayone.txt");

    public void Solve()
    {
        var elves = new List<Elf>();
        var lines = File.ReadAllText(PATH).Split("\n\n");
        int i = 1;
        foreach(var line in lines)
        {
            var elv = new Elf() { Id = i++ };
            elv.FillFromListOfStrings(line.Split("\n").ToList());
            elves.Add(elv);
        }

        Console.WriteLine($"The elf with the most calories: {__GetSumOfCaloriesFromBiggestElf(elves)}");
        Console.WriteLine($"The {3} elves with the most calories add up to: {__GetSumOfCaloriesFromNBiggestElf(elves, 3)}");
    }

    private int __GetSumOfCaloriesFromBiggestElf(List<Elf> elves)
    {
        return elves.Max(x => x.CalorieSum);
    }

    private int __GetSumOfCaloriesFromNBiggestElf(List<Elf> elves, int n)
    {
        return elves.OrderByDescending(x => x.CalorieSum).Take(n).Sum(x => x.CalorieSum);
    }
}
