using DesignPattern.FacadePattern.lib;

namespace DesignPattern.FacadePattern;

public class Program
{
    public static void Main()
    {
        var gameFacade = new GameFacade();
        
        gameFacade.InitializeGame();
    }
}