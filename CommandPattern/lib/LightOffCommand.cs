namespace DesignPattern.CommandPattern.lib;

public class LightOffCommand : Command
{
    private readonly Light light;
    
    public LightOffCommand(Light light)
    {
        this.light = light;
    }

    public override void Execute()
    {
        this.light.Off();
    }
}