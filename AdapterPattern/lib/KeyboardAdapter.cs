namespace DesignPattern.AdapterPattern.lib;

public class KeyboardAdapter : InputDevice
{
    private readonly Keyboard keyboard;

    public KeyboardAdapter(Keyboard keyboard)
    {
        this.keyboard = keyboard;
    }
    
    public override void HandlerInput()
    {
        this.keyboard.PreeKey();
    }
}