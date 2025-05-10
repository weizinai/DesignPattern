using System;

namespace DesignPattern.StatePattern.lib;

public class Player
{
    private IState? state;

    public void SetState(IState _state)
    {
        this.state = _state;
    }

    public void Request()
    {
        if (this.state != null)
        {
            this.state.Handle();
        }
        else
        {
            Console.WriteLine("No state set!");
        }
    }
}