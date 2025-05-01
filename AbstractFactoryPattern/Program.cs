using DesignPattern.AbstractFactoryPattern.lib;

namespace DesignPattern.AbstractFactoryPattern;

public class Program
{
    public static void Main()
    {
        var warriorFactory = new WarriorFactory();
        var warrior = new Character(warriorFactory);
        warrior.Equip();
        
        var mageFactory = new MageFactory();
        var mage = new Character(mageFactory);
        mage.Equip();
    }
}