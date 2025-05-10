using System;

namespace DesignPattern.MediatorPattern.lib;

public class User : Colleague
{
    private readonly string name;
    
    public User(Mediator mediator, string name) : base(mediator)
    {
        this.name = name;
    }

    public void Send(string message)
    {
        this.Mediator.Send(message, this);
    }
    
    public override void Receive(string message)
    {
        Console.WriteLine($"{this.name} received: {message}");
    }
}