using DesignPattern.FactoryMethodPattern.lib;

namespace DesignPattern.FactoryMethodPattern;

public class Program
{
    public static void Main()
    {
        var swordFactory = new SwordFactory();
        var sword = swordFactory.CreateWeapon();
        sword.Use();
        
        var bowFactory = new BowFactory();
        var bow = bowFactory.CreateWeapon();
        bow.Use();
    }
}