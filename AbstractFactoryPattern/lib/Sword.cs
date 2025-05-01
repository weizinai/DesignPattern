using System;

namespace DesignPattern.AbstractFactoryPattern.lib;

public class Sword : Weapon
{
    public override void Use()
    {
        Console.WriteLine("Swinging the sword!");
    }
}