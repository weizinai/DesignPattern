using System;

namespace DesignPattern.ChainOfResponsibilityPattern.lib;

public class ItemValidator : TaskValidator
{
    public override void HandleRequest(TaskValidationRequest request)
    {
        if (!request.HasRequiredItem)
        {
            request.ErrorMessage = "缺少任务道具：古老卷轴";
            return;
        }

        Console.WriteLine("[道具验证通过]");
        this.Next?.HandleRequest(request);
    }
}