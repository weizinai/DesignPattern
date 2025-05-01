namespace DesignPattern.DecoratorPattern.lib;

public class AttackPowerDecorator : CharacterDecorator
{
    private readonly int additionalPower;
    
    public AttackPowerDecorator(Character character, int additionalPower) : base(character)
    {
        this.additionalPower = additionalPower;
    }

    public override void Attack()
    {
        Console.WriteLine($"Attack power increased by {this.additionalPower}!");
        base.Attack();
    }
}