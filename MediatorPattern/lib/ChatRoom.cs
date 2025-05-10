using System.Collections.Generic;

namespace DesignPattern.MediatorPattern.lib;

public class ChatRoom : Mediator
{
    private readonly List<Colleague> colleagues = new();

    public void AddColleague(Colleague colleague)
    {
        this.colleagues.Add(colleague);
    }
    
    public override void Send(string message, Colleague sender)
    {
        foreach (var colleague in this.colleagues)
        {
            if (colleague != sender)
            {
                colleague.Receive(message);
            }
        }
    }
}