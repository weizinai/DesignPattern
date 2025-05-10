using System;

namespace DesignPattern.MementoPattern.lib;

public class GameCharacter
{
    public class Memento
    {
        private readonly int health;
        private readonly int level;
        
        public Memento(int health, int level)
        {
            this.health = health;
            this.level = level;
        }
        
        public int GetHealth() => this.health;
        public int GetLevel() => this.level;
    }
    
    private readonly string name;
    private int health;
    private int level;

    public GameCharacter(string name, int health, int level)
    {
        this.name = name;
        this.health = health;
        this.level = level;
    }

    public void Display()
    {
        Console.WriteLine($"Character: {this.name} | Health: {this.health} | Level: {this.level}");
    }

    public void TakeDamage(int damage)
    {
        this.health -= damage;
        if (this.health <= 0) this.health = 0;
    }

    public void LevelUp()
    {
        this.level++;
    }
    
    public Memento SaveState() => new Memento(this.health, this.level);

    public void RestoreState(Memento memento)
    {
        this.health = memento.GetHealth();
        this.level = memento.GetLevel();
    }
}