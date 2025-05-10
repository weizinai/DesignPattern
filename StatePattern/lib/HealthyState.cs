using System;

namespace DesignPattern.StatePattern.lib;

public class HealthyState : IState
{
    public void Handle()
    {
        Console.WriteLine("Player is healthy!");
    }
}