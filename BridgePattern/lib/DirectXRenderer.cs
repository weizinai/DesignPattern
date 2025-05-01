using System;

namespace DesignPattern.BridgePattern.lib;

public class DirectXRenderer : Renderer
{
    public override void RenderShape(string shapeName)
    {
        Console.WriteLine($"Rendering {shapeName} with DirectX.");
    }
}