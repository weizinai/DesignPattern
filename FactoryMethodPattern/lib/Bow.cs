using System;

namespace DesignPattern.FactoryMethodPattern.lib;

public class Bow : Weapon
{
    public override void Use()
    {
        Console.WriteLine("Shooting arrow!");
    }
}