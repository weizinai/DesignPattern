using System;
using DesignPattern.TemplateMethodPattern.lib;

namespace DesignPattern.TemplateMethodPattern;

public class DinnerCooking : CookingTemplate
{
    protected override void PrepareIngredients()
    {
        Console.WriteLine("Preparing chicken, vegetable, and rice for dinner.");
    }

    protected override void CookMainDish()
    {
        Console.WriteLine("Cooking chicken and boiling rice.");
    }
}