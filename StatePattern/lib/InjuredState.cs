using System;

namespace DesignPattern.StatePattern.lib;

public class InjuredState : IState
{
    public void Handle()
    {
        Console.WriteLine("Player is injured!");
    }
}