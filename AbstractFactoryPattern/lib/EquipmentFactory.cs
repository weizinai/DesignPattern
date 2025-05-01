namespace DesignPattern.AbstractFactoryPattern.lib;

public abstract class EquipmentFactory
{
    public abstract Weapon CreateWeapon();
    
    public abstract Armor CreateArmor();
}