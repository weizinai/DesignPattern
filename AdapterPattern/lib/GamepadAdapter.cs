namespace DesignPattern.AdapterPattern.lib;

public class GamepadAdapter : InputDevice
{
    private readonly Gamepad gamepad;
    
    public GamepadAdapter(Gamepad gamepad)
    {
        this.gamepad = gamepad;
    }

    public override void HandlerInput()
    {
        this.gamepad.PressButton();
    }
}