using System;

namespace DesignPattern.CommandPattern.lib;

public class Light
{
    public void On()
    {
        Console.WriteLine("Light is ON");
    }

    public void Off()
    {
        Console.WriteLine("Light is OFF");
    }

    public void Dim(int level)
    {
        Console.WriteLine($"Light dimmed to {level}");
    }
}