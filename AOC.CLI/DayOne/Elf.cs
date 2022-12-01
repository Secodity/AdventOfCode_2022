using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC.CLI.DayOne;
public record Elf
{
    public int Id { get; set; }
    public List<int> Calories { get; set; } = new();
    public int CalorieSum => Calories.Sum();
    public void FillFromListOfStrings(List<string> values)
    {
        foreach(var value in values)
        {
            if (!int.TryParse(value, out var num))
                continue;
            Calories.Add(num);
        }
    }
}
