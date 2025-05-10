namespace DesignPattern.ObserverPattern.lib;

public abstract class Subject
{
    public abstract void Attach(Observer observer);
    public abstract void Detach(Observer observer);
    public abstract void Notify();
}