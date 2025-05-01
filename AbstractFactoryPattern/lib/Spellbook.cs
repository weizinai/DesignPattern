using System;

namespace DesignPattern.AbstractFactoryPattern.lib;

public class Spellbook : Armor
{
    public override void Equip()
    {
        Console.WriteLine("Reading the spellbook!");
    }
}