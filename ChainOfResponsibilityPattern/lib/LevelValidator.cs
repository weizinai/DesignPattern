using System;

namespace DesignPattern.ChainOfResponsibilityPattern.lib;

public class LevelValidator : TaskValidator
{
    public override void HandleRequest(TaskValidationRequest request)
    {
        const int requiredLevel = 10;

        if (request.PlayerLevel < requiredLevel)
        {
            request.ErrorMessage = "等级不足（需10级）";
            return;
        }

        Console.WriteLine("[等级验证通过]");
        this.Next?.HandleRequest(request);
    }
}