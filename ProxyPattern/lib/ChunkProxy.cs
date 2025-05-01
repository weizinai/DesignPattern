using System;

namespace DesignPattern.ProxyPattern.lib;

public class ChunkProxy : IChunk
{
    private readonly int x, y;
    private RealChunk? realChunk;
    
    public ChunkProxy(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    ~ChunkProxy()
    {
        this.realChunk = null;
    }

    public void Load()
    {
        this.realChunk ??= new RealChunk(this.x, this.y);
        this.realChunk.Load();
    }
    public void Render()
    {
        if (this.realChunk != null)
        {
            this.realChunk.Render();
        }
        else
        {
            Console.WriteLine($"Chunk at ({this.x}, {this.y}) not loaded yet. Please load first.");
        }
    }
}