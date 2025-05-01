namespace DesignPattern.BuilderPattern.lib;

public class GameLevelDirector
{
    private readonly LevelBuilder builder;
    
    public GameLevelDirector(LevelBuilder builder)
    {
        this.builder = builder;
    }

    public GameLevel CreateEasyLevelType1()
    {
        this.builder.ClearLevel();
        
        this.builder.SetLevelName("Forest");
        this.builder.AddEnemy("Goblin");
        this.builder.AddEnemy("Wolf");
        this.builder.AddObstacle("Tree");
        this.builder.AddObstacle("Rock");
        this.builder.AddItem("Health Point");
        this.builder.AddItem("Magic Stone");
        
        return this.builder.Build();
    }

    public GameLevel CreateEasyLevelType2()
    {
        this.builder.ClearLevel();
        
        this.builder.SetLevelName("Dungeon");
        this.builder.AddEnemy("Dragon");
        this.builder.AddEnemy("Undead Warrior");
        this.builder.AddObstacle("Trap");
        this.builder.AddObstacle("Pit");
        this.builder.AddItem("Sword of Power");
        this.builder.AddItem("Shield of Power");
        
        return this.builder.Build();
    }
}