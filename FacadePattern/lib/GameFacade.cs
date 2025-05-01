namespace DesignPattern.FacadePattern.lib;

public class GameFacade
{
    private readonly GraphicSystem graphicSystem = new();
    private readonly AudioSystem audioSystem = new();
    private readonly PhysicsEngine  physicsEngine = new();
    private readonly InputManager inputManager = new();

    public void InitializeGame()
    {
        this.graphicSystem.Initialize();
        this.audioSystem.Initialize();
        this.physicsEngine.Initialize();
        this.inputManager.Initialize();
    }
}