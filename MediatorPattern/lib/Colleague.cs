namespace DesignPattern.MediatorPattern.lib;

public abstract class Colleague
{
    protected readonly Mediator Mediator;
    
    protected Colleague(Mediator mediator)
    {
        this.Mediator = mediator;
    }

    public abstract void Receive(string message);
}