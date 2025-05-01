namespace DesignPattern.BridgePattern.lib;

public abstract class Shape
{
    protected Renderer Renderer;
    
    protected Shape(Renderer renderer)
    {
        this.Renderer = renderer;
    }

    public abstract void Draw();
}