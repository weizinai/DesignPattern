namespace DesignPattern.ChainOfResponsibilityPattern.lib;

public class TaskValidationRequest
{
    public int PlayerLevel = 15;
    public bool HasRequiredItem = false;
    public bool IsPreQuestCompleted = false;
    public string ErrorMessage = "";
}