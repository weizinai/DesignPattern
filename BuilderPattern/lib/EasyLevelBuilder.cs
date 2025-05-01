namespace DesignPattern.BuilderPattern.lib;

public class EasyLevelBuilder : LevelBuilder
{
    public override void SetLevelName(string name)
    {
        this.Level.LevelName = name;
    }

    public override void AddEnemy(string enemy)
    {
        this.Level.Enemies.Add(enemy);
    }

    public override void AddObstacle(string obstacle)
    {
        this.Level.Obstacles.Add(obstacle);
    }

    public override void AddItem(string item)
    {
        this.Level.Items.Add(item);
    }

    public override GameLevel Build()
    {
        return this.Level;
    }
}