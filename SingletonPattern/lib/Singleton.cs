namespace DesignPattern.SingletonPattern.lib;

public class Singleton
{
    public static readonly Singleton Instance = new();

    public void ShowMessage()
    {
        Console.WriteLine("Hello from Singleton!");
    }
}