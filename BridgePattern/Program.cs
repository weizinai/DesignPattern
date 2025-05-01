using DesignPattern.BridgePattern.lib;

namespace DesignPattern.BridgePattern;

public class Program
{
    public static void Main()
    {
        var openglRenderer = new OpenGLRenderer();
        var directXRenderer = new DirectXRenderer();
        
        var circle1 = new Circle(openglRenderer);
        var rectangle1 = new Rectangle(openglRenderer);
        
        circle1.Draw();
        rectangle1.Draw();
        
        var circle2 = new Circle(directXRenderer);
        var rectangle2 = new Rectangle(directXRenderer);
        
        circle2.Draw();
        rectangle2.Draw();
    }
}