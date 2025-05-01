namespace DesignPattern.FactoryMethodPattern.lib;

public class SwordFactory : WeaponFactory
{
    public override Weapon CreateWeapon()
    {
        return new Sword();
    }
}