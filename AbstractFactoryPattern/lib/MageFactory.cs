namespace DesignPattern.AbstractFactoryPattern.lib;

public class MageFactory:EquipmentFactory
{
    public override Weapon CreateWeapon()
    {
        return new Staff();
    }
    public override Armor CreateArmor()
    {
        return new Spellbook();
    }
}