using DesignPattern.ProxyPattern.lib;

namespace DesignPattern.ProxyPattern;

public class Program
{
    public static void Main()
    {
        var chunk1 = new ChunkProxy(1, 1);
        var chunk2 = new ChunkProxy(2, 2);
        
        chunk1.Load();
        
        chunk1.Render();
        chunk2.Render();
        
        chunk2.Load();
        chunk2.Render();
    }
}