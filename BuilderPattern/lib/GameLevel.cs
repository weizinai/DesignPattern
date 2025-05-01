using System;
using System.Collections.Generic;

namespace DesignPattern.BuilderPattern.lib;

public class GameLevel
{
    public string LevelName { get; set; } = "";
    public List<string> Enemies { get; set; } = new();
    public List<string> Obstacles { get; set; } = new();
    public List<string> Items { get; set; } = new();

    public void Run()
    {
        var description = $"Level Name: {this.LevelName}\n" +
                          $"Enemies: {string.Join(", ", this.Enemies)}\n" +
                          $"Obstacles: {string.Join(", ", this.Obstacles)}\n" +
                          $"Items: {string.Join(", ", this.Items)}";
        
        Console.WriteLine(description);
    }
}