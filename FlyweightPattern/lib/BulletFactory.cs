using System.Collections.Generic;

namespace DesignPattern.FlyweightPattern.lib;

public class BulletFactory
{
    private readonly Dictionary<string, BulletFlyweight>  bullets = new();
    
    public BulletFlyweight GetBullet(string texture)
    {
        if (!this.bullets.ContainsKey(texture))
        {
            this.bullets[texture] = new BulletFlyweight(texture);
        }
        return this.bullets[texture];
    }
}