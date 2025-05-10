using System;

namespace DesignPattern.VisitorPattern.lib;

public class AttackVisitor : Visitor
{
    public override void Visit(Monster monster)
    {
        monster.Health -= 20;
        Console.WriteLine($"攻击怪物！剩余血量：{monster.Health}");
    }

    public override void Visit(TreasureChest chest)
    {
        if (chest.IsLocked)
        {
            Console.WriteLine("宝箱被几大后解锁！");
            chest.IsLocked = false;
        }
    }
}