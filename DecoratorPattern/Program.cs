using DesignPattern.DecoratorPattern.lib;

namespace DesignPattern.DecoratorPattern;

public class Program
{
    public static void Main()
    {
        var character = new BasicCharacter();
        character.Attack();
        
        var enhancedCharacter = new AttackPowerDecorator(character, 20);
        enhancedCharacter.Attack();
    }
}