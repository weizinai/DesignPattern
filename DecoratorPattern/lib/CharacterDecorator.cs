namespace DesignPattern.DecoratorPattern.lib;

public class CharacterDecorator : Character
{
    private readonly Character character;

    protected CharacterDecorator(Character character)
    {
        this.character = character;
    }

    public override void Attack()
    {
        this.character.Attack();
    }
}