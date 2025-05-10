namespace DesignPattern.VisitorPattern.lib;

public class Monster : Element
{
    public int Health = 100;
    
    public override void Accept(Visitor visitor)
    {
        visitor.Visit(this);
    }
}