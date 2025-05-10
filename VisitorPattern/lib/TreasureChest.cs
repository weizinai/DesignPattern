namespace DesignPattern.VisitorPattern.lib;

public class TreasureChest : Element
{
    public bool IsLocked = true;
    
    public override void Accept(Visitor visitor)
    {
        visitor.Visit(this);
    }
}