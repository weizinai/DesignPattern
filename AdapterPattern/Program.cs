using DesignPattern.AdapterPattern.lib;

namespace DesignPattern.AdapterPattern;

public class Program
{
    public static void Main()
    {
        var useKeyboard = true;
        
        InputDevice? inputDevice = null;

        if (useKeyboard)
        {
            var keyboard = new Keyboard();
            inputDevice = new KeyboardAdapter(keyboard);
        }
        else
        {
            var gamepad = new Gamepad();
            inputDevice = new GamepadAdapter(gamepad);
        }
        
        inputDevice.HandlerInput();
    }
}