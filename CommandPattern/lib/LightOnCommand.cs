namespace DesignPattern.CommandPattern.lib;

public class LightOnCommand : Command
{
    private readonly Light light;
    
    public LightOnCommand(Light light)
    {
        this.light = light;
    }

    public override void Execute()
    {
        this.light.On();    
    }
}