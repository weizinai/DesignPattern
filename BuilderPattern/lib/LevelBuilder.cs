namespace DesignPattern.BuilderPattern.lib;

public abstract class LevelBuilder
{
    protected GameLevel Level = new();
    
    public abstract void SetLevelName(string name);
    
    public abstract void AddEnemy(string enemy);
   
    public abstract void AddObstacle(string obstacle);
    
    public abstract void AddItem(string item);
    
    public abstract GameLevel Build();

    public void ClearLevel()
    {
        this.Level = new GameLevel();
    }
}