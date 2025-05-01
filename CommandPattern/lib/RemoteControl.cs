namespace DesignPattern.CommandPattern.lib;

public class RemoteControl
{
    private Command? command;

    public void SetCommand(Command _command)
    {
        this.command = _command;
    }

    public void PressButton()
    {
        this.command?.Execute();
    }
}
