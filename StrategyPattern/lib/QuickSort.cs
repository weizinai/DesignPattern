using System;
using System.Collections.Generic;

namespace DesignPattern.StrategyPattern.lib;

public class QuickSort : ISortStrategy
{
    public void Sort(List<int> data)
    {
        Console.WriteLine("Using Quick Sort");
    }
}