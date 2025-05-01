using System;

namespace DesignPattern.AbstractFactoryPattern.lib;

public class Shield : Armor
{
    public override void Equip()
    {
        Console.WriteLine("Equipping shield!");
    }
}