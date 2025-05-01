using System;

namespace DesignPattern.FactoryMethodPattern.lib;

public class Sword : Weapon
{
    public override void Use()
    {
        Console.WriteLine("Swinging sword!");
    }
}