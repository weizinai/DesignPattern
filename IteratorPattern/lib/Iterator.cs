namespace DesignPattern.IteratorPattern.lib;

public interface IIterator
{
    public bool HasNext();

    public string Next();
}