using System;

namespace DesignPattern.TemplateMethodPattern.lib;

public abstract class CookingTemplate
{
    public void Cook()
    {
        this.PrepareIngredients();
        this.CookMainDish();
        this.Serve();
    }

    protected abstract void PrepareIngredients();

    protected abstract void CookMainDish();

    private void Serve()
    {
        Console.WriteLine("Serving the dish!");
    }
}