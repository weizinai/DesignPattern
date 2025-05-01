namespace DesignPattern.BridgePattern.lib;

public class Rectangle : Shape
{
    public Rectangle(Renderer renderer) : base(renderer) { }
    
    public override void Draw()
    {
        this.Renderer.RenderShape("Rectangle");
    }
}