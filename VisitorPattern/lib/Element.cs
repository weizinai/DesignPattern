namespace DesignPattern.VisitorPattern.lib;

public abstract class Element
{
    public abstract void Accept(Visitor visitor);
}