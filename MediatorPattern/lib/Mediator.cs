namespace DesignPattern.MediatorPattern.lib;

public abstract class Mediator
{
    public abstract void Send(string message, Colleague sender);
}