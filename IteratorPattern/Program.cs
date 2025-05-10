using System;
using DesignPattern.IteratorPattern.lib;

namespace DesignPattern.IteratorPattern;

public class Program
{
    public static void Main()
    {
        var gameUnits = new GameUnits();
        var iterator = gameUnits.CreateIterator();

        while (iterator.HasNext())
        {
            Console.WriteLine($"Game Unit: {iterator.Next()}");
        }
    }
}