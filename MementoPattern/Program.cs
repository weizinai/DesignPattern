using DesignPattern.MementoPattern.lib;

namespace DesignPattern.MementoPattern;

public class Program
{
    public static void Main()
    {
        var character = new GameCharacter("Hero", 100, 1);
        var caretaker = new Caretaker();
        
        character.Display();

        caretaker.SaveMemento(character.SaveState());
        
        character.TakeDamage(39);
        character.LevelUp();
        character.Display();
        
        character.RestoreState(caretaker.GetMemento(0));
        character.Display();
    }
}