namespace DesignPattern.VisitorPattern.lib;

public abstract  class Visitor
{
    public abstract void Visit(Monster monster);

    public abstract void Visit(TreasureChest chest);
}