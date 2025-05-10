using System.Collections.Generic;
using DesignPattern.StrategyPattern.lib;

namespace DesignPattern.StrategyPattern;

public class Program
{
    public static void Main()
    {
        var data = new List<int> { 5, 2, 9, 1, 5, 6 };

        var context = new SortContext(new BubbleSort());
        context.ExecuteStrategy(data);
        
        context.SetStrategy(new QuickSort());
        context.ExecuteStrategy(data);
    }
}