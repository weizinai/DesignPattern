using System.Collections.Generic;

namespace DesignPattern.ObserverPattern.lib;

public class ConcreteSubject : Subject
{
    private readonly List<Observer> observers = new();
    private int state;

    public void SetState(int newState)
    {
        this.state = newState;
        this.Notify();
    }

    public override void Attach(Observer observer)
    {
        this.observers.Add(observer);
    }

    public override void Detach(Observer observer)
    {
        this.observers.Remove(observer);
    }

    public override void Notify()
    {
        foreach (var observer in this.observers)
        {
            observer.Update(this.state);
        }
    }
}