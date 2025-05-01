using DesignPattern.CommandPattern.lib;

namespace DesignPattern.CommandPattern;

public class Program
{
    public static void Main()
    {
        var light = new Light();
        var lightOn = new LightOnCommand(light);
        var lightOff = new LightOffCommand(light);
        var lightDim = new LightDimCommand(light, 50);

        var remote = new RemoteControl();
        remote.SetCommand(lightOn);
        remote.PressButton();
        
        remote.SetCommand(lightOff);
        remote.PressButton();
        
        remote.SetCommand(lightDim);
        remote.PressButton();
    }
}