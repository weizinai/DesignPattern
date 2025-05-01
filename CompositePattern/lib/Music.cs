

namespace DesignPattern.CompositePattern.lib;

public class Music : GameObject
{
    public override void OnUpdate()
    {
        Console.WriteLine("Music Tick!");
        base.OnUpdate();
    }
}