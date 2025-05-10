using DesignPattern.TemplateMethodPattern.lib;

namespace DesignPattern.TemplateMethodPattern;

public class Program
{
    public static void Main()
    {
        var breakfast = new BreakfastCooking();
        breakfast.Cook();

        var dinner = new DinnerCooking();
        dinner.Cook();
    }
}