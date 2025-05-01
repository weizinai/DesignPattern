namespace DesignPattern.CommandPattern.lib;

public class LightDimCommand : Command
{
    private readonly Light light;
    private readonly int level;
    
    public LightDimCommand(Light light, int level)
    {
        this.light = light;
        this.level = level;
    }

    public override void Execute()
    {
        this.light.Dim(this.level);
    }
}