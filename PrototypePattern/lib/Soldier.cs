using System;

namespace DesignPattern.PrototypePattern.lib;

public class Soldier : Prototype
{
    private readonly string type;
    private readonly int health;
    private readonly int attack;
    private readonly int defense;

    public Soldier(string type, int health, int attack, int defense)
    {
        this.type = type;
        this.health = health;
        this.attack = attack;
        this.defense = defense;
    }

    private Soldier(Soldier other) : this(other.type, other.health, other.attack, other.defense) { }

    public override Prototype Clone()
    {
        return new Soldier(this);
    }

    public override void ShowInfo()
    {
        var description = $"Soldier Type: {this.type}\n" +
                          $"Health: {this.health}\n" +
                          $"Attack: {this.attack}\n" +
                          $"Defense: {this.defense}";

        Console.WriteLine(description);
    }
}