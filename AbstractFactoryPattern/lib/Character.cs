namespace DesignPattern.AbstractFactoryPattern.lib;

public class Character
{
    private readonly EquipmentFactory equipmentFactory;

    public Character(EquipmentFactory equipmentFactory)
    {
        this.equipmentFactory = equipmentFactory;
    }

    public void Equip()
    {
        var weapon = this.equipmentFactory.CreateWeapon();
        var armor = this.equipmentFactory.CreateArmor();
        
        weapon.Use();
        armor.Equip();
    }
}