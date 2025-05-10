using System;
using System.Collections.Generic;

namespace DesignPattern.StrategyPattern.lib;

public class BubbleSort : ISortStrategy
{
    public void Sort(List<int> data)
    {
        Console.WriteLine("Using Bubble Sort");
    }
}