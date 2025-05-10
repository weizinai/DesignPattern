using DesignPattern.StatePattern.lib;

namespace DesignPattern.StatePattern;

public class Program
{
    public static void Main()
    {
        var player = new Player();

        var healthyState = new HealthyState();
        player.SetState(healthyState);
        player.Request();
        
        var injuredState = new InjuredState();
        player.SetState(injuredState);
        player.Request();
        
        var deadState = new DeadState();
        player.SetState(deadState);
        player.Request();
    }
}