using System.Collections.Generic;

namespace DesignPattern.IteratorPattern.lib;

public class GameUnits : ICollection
{
    private readonly List<string> units = new();

    public GameUnits()
    {
        this.units.Add("Knight");
        this.units.Add("Archer");
        this.units.Add("Mage");
    }
    
    public IIterator CreateIterator()
    {
        return new ConcreteIterator(this.units);
    }
}