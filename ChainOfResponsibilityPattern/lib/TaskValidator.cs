namespace DesignPattern.ChainOfResponsibilityPattern.lib;

public abstract class TaskValidator
{
    protected TaskValidator? Next;

    public abstract void HandleRequest(TaskValidationRequest request);

    public void SetNext(TaskValidator next)
    {
        this.Next = next;
    }
}