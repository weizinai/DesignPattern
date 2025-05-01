using System;

namespace DesignPattern.DecoratorPattern.lib;

public class BasicCharacter : Character
{
    public override void Attack()
    {
        Console.WriteLine("Basic attack!");
    }
}