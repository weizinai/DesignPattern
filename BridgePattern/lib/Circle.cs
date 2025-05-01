namespace DesignPattern.BridgePattern.lib;

public class Circle : Shape
{
    public Circle(Renderer renderer) : base(renderer) { }
    
    public override void Draw()
    {
        this.Renderer.RenderShape("Circle");
    }
}