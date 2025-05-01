using DesignPattern.PrototypePattern.lib;

namespace DesignPattern.PrototypePattern;

public class Program
{
    public static void Main()
    {
        var soldierPrototype = new Soldier("Infantry", 100, 10, 5);
        var archerPrototype = new Archer("Longbow", 80, 15, 3);
        var knightPrototype = new Knight("Cavalry", 150, 20, 10);

        var clonedSoldier = soldierPrototype.Clone();
        var clonedArcher = archerPrototype.Clone();
        var clonedKnight = knightPrototype.Clone();
        
        clonedSoldier.ShowInfo();
        clonedArcher.ShowInfo();
        clonedKnight.ShowInfo();
    }
}