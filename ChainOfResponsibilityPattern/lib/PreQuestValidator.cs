using System;

namespace DesignPattern.ChainOfResponsibilityPattern.lib;

public class PreQuestValidator : TaskValidator
{
    public override void HandleRequest(TaskValidationRequest request)
    {
        if (!request.IsPreQuestCompleted)
        {
            Console.WriteLine("未完成前置任务：寻找信使");
            return;
        }

        Console.WriteLine("[前置任务验证通过]");
    }
}