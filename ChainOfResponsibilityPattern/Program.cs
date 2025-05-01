using System;
using DesignPattern.ChainOfResponsibilityPattern.lib;

namespace DesignPattern.ChainOfResponsibilityPattern;

public class Program
{
    public static void Main()
    {
        var levelCheck = new LevelValidator();
        var itemCheck = new ItemValidator();
        var preQuestCheck = new PreQuestValidator();

        levelCheck.SetNext(itemCheck);
        itemCheck.SetNext(preQuestCheck);

        var request = new TaskValidationRequest
        {
            PlayerLevel = 15,
            HasRequiredItem = true
        };

        levelCheck.HandleRequest(request);

        Console.WriteLine(request.ErrorMessage.Length == 0 ? "任务提交成功！" : $"提交失败：{request.ErrorMessage}");
    }
}