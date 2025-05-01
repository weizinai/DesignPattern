namespace DesignPattern.PrototypePattern.lib;

public interface IPrototype
{
    public IPrototype Clone();
    
    public void ShowInfo();
}