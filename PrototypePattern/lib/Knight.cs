namespace DesignPattern.PrototypePattern.lib;

public class Knight : IPrototype
{
    private readonly string type;
    private readonly int health;
    private readonly int attack;
    private readonly int defense;

    public Knight(string type, int health, int attack, int defense)
    {
        this.type = type;
        this.health = health;
        this.attack = attack;
        this.defense = defense;
    }

    private Knight(Knight other) : this(other.type, other.health, other.attack, other.defense) { }

    public IPrototype Clone()
    {
        return new Knight(this);
    }

    public void ShowInfo()
    {
        var description = $"Knight Type: {this.type}\n" +
                          $"Health: {this.health}\n" +
                          $"Attack: {this.attack}\n" +
                          $"Defense: {this.defense}";

        Console.WriteLine(description);
    }
}