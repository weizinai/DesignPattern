namespace DesignPattern.ProxyPattern.lib;

public class RealChunk : IChunk
{
    private readonly int x, y;

    public RealChunk(int x, int y)
    {
        this.x = x;
        this.y = y;
        Console.WriteLine($"Loading chunk at ({this.x}, {this.y})");
    }

    public void Load()
    {
        Console.WriteLine($"Chunk at ({this.x}, {this.y}) is now loaded!");
    }

    public void Render()
    {
        Console.WriteLine($"Rendering chunk at ({this.x}, {this.y})");
    }
}