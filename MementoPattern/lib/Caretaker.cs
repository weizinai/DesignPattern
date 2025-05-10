using System.Collections.Generic;

namespace DesignPattern.MementoPattern.lib;

public class Caretaker
{
    private readonly List<GameCharacter.Memento> history = new();

    public void SaveMemento(GameCharacter.Memento memento)
    {
        this.history.Add(memento);
    }

    public GameCharacter.Memento GetMemento(int index)
    {
        return this.history[index];
    }
}