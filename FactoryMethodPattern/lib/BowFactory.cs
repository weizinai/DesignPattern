namespace DesignPattern.FactoryMethodPattern.lib;

public class BowFactory : WeaponFactory
{
    public override Weapon CreateWeapon()
    {
        return new Bow();
    }
}