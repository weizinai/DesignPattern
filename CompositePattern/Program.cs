using DesignPattern.CompositePattern.lib;

namespace DesignPattern.CompositePattern;

public class Program
{
    public static void Main()
    {
        var player1 = new GameObject();
        
        player1.AddChild(new Sprite());
        player1.AddChild(new Music());
        
        var player2 = new GameObject();
        player2.AddChild(new Sprite());
        player2.AddChild(new Music());

        var scene = new GameObject();
        scene.AddChild(player1);
        scene.AddChild(player2);
        
        scene.OnUpdate();
    }
}