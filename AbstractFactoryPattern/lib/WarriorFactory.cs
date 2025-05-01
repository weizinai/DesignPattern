namespace DesignPattern.AbstractFactoryPattern.lib;

public class WarriorFactory : EquipmentFactory
{
    public override Weapon CreateWeapon()
    {
        return new Sword();
    }

    public override Armor CreateArmor()
    {
        return new Shield();
    }
}