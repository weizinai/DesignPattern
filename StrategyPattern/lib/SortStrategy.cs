using System.Collections.Generic;

namespace DesignPattern.StrategyPattern.lib;

public interface ISortStrategy
{
    public void Sort(List<int> data);
}