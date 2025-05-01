using DesignPattern.SingletonPattern.lib;

namespace DesignPattern.SingletonPattern;

public class Program
{
    public static void Main()
    {
        Singleton.Instance.ShowMessage();
    }
}