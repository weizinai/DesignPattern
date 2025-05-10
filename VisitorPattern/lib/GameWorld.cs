using System.Collections.Generic;

namespace DesignPattern.VisitorPattern.lib;

public class GameWorld
{
    private readonly List<Element> elements = new();

    public void AddElement(Element element)
    {
        this.elements.Add(element);
    }

    public void ApplyVisitor(Visitor visitor)
    {
        foreach (var element in this.elements)
        {
            element.Accept(visitor);
        }
    }
}