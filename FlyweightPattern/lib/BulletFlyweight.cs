using System;

namespace DesignPattern.FlyweightPattern.lib;

public class BulletFlyweight
{
    private readonly string texture;
    
    public BulletFlyweight(string texture)
    {
        this.texture = texture;
    }

    public void Render(int x, int y)
    {
        Console.WriteLine($"Rendering bullet at ({x}, {y}) with texture: {this.texture}");
    }
}