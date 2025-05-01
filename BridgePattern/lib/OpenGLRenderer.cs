namespace DesignPattern.BridgePattern.lib;

public class OpenGLRenderer : Renderer
{
    public override void RenderShape(string shapeName)
    {
        Console.WriteLine($"Rendering {shapeName} with OpenGL.");
    }
}