namespace DesignPattern.FlyweightPattern.lib;

public class Bullet
{
    private readonly BulletFlyweight bullet;
    private int x, y;
    
    public Bullet(BulletFlyweight bullet, int x, int y)
    {
        this.bullet = bullet;
        this.x = x;
        this.y = y;
    }

    public void Move(int dx, int dy)
    {
        this.x += dx;
        this.y += dy;
    }

    public void Render()
    {
        this.bullet.Render(this.x,  this.y);
    }
}