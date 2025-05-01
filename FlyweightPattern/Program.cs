using DesignPattern.FlyweightPattern.lib;

namespace DesignPattern.FlyweightPattern;

public class Program
{
    public static void Main()
    {
        var bulletFactory = new BulletFactory();

        var bullet1 = bulletFactory.GetBullet("BulletTexture");
        var bullet2 = bulletFactory.GetBullet("BulletTexture");
        var bullet3 = bulletFactory.GetBullet("BulletTexture");

        var bullets = new[]
        {
            new Bullet(bullet1, 10, 20),
            new Bullet(bullet2, 15, 25),
            new Bullet(bullet3, 20, 30),
        };

        foreach (var bullet in bullets)
        {
            bullet.Move(5, 0);
            bullet.Render();
        }
    }
}