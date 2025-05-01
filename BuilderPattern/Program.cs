using DesignPattern.BuilderPattern.lib;

namespace DesignPattern.BuilderPattern;

public class Program
{
    public static void Main()
    {
        var eastLevelBuilder = new EasyLevelBuilder();
        var gameLevelDirector = new GameLevelDirector(eastLevelBuilder);

        var easyLevelType1 = gameLevelDirector.CreateEasyLevelType1();
        var easyLevelType2 = gameLevelDirector.CreateEasyLevelType2();
        
        easyLevelType1.Run();
        easyLevelType2.Run();
    }
}