using DesignPattern.VisitorPattern.lib;

namespace DesignPattern.VisitorPattern;

public class Program
{
    public static void Main()
    {
        var world = new GameWorld();
        world.AddElement(new Monster());
        world.AddElement(new TreasureChest());

        var attacker = new AttackVisitor();
        world.ApplyVisitor(attacker);
    }
}