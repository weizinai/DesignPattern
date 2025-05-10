using System;

namespace DesignPattern.TemplateMethodPattern.lib;

public class BreakfastCooking : CookingTemplate
{
    protected override void PrepareIngredients()
    {
        Console.WriteLine("Preparing eggs, bread, and juice for breakfast.");
    }

    protected override void CookMainDish()
    {
        Console.WriteLine("Cooking eggs and toasting bread.");
    }
}