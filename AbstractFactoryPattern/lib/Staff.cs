using System;

namespace DesignPattern.AbstractFactoryPattern.lib;

public class Staff : Weapon
{
    public override void Use()
    {
        Console.WriteLine("Casting spell with the staff!");
    }
}