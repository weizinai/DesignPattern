namespace DesignPattern.CompositePattern.lib;

public class GameObject
{
    private readonly List<GameObject> childList = new();

    public void AddChild(GameObject child)
    {
        this.childList.Add(child);
    }

    public virtual void OnUpdate()
    {
        foreach (var child in this.childList)
        {
            child.OnUpdate();
        }
    }
}