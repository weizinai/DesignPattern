using System;

namespace DesignPattern.StatePattern.lib;

public class DeadState : IState
{
    public void Handle()
    {
        Console.WriteLine("Player is dead!");
    }
}