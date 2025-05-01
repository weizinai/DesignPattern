namespace DesignPattern.CompositePattern.lib;

public class Sprite : GameObject
{
     public override void OnUpdate()
     {
          Console.WriteLine("Sprite Tick!");
          base.OnUpdate();
     }
}