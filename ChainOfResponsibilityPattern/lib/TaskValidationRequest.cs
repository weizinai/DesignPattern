namespace DesignPattern.ChainOfResponsibilityPattern.lib;

public class TaskValidationRequest
{
    public readonly int PlayerLevel;
    public readonly bool HasRequiredItem;
    public readonly bool IsPreQuestCompleted;
    public string ErrorMessage = "";
    
    public TaskValidationRequest(int playerLevel = 15, bool hasRequiredItem = false, bool isPreQuestCompleted = false)
    {
        this.PlayerLevel = playerLevel;
        this.HasRequiredItem = hasRequiredItem;
        this.IsPreQuestCompleted = isPreQuestCompleted;
    }
}