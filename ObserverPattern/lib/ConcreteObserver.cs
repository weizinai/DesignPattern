using System;

namespace DesignPattern.ObserverPattern.lib;

public class ConcreteObserver : Observer
{
    private readonly string name;
    
    public ConcreteObserver(string name)
    {
        this.name = name;
    }

    public override void Update(int state)
    {
        Console.WriteLine($"{this.name} received notification! New state: {state}");
    }
}