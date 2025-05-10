using System.Collections.Generic;

namespace DesignPattern.IteratorPattern.lib;

public class ConcreteIterator : IIterator
{
    private readonly List<string> units;
    private int index;

    public ConcreteIterator(List<string> units)
    {
        this.units = units;
    }

    public bool HasNext()
    {
        return this.index < this.units.Count;
    }
    
    public string Next()
    {
        return this.units[this.index++];
    }
}