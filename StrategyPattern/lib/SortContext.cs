using System.Collections.Generic;

namespace DesignPattern.StrategyPattern.lib;

public class SortContext
{
    private ISortStrategy strategy;
    
    public SortContext(ISortStrategy strategy)
    {
        this.strategy = strategy;
    }

    public void SetStrategy(ISortStrategy _strategy)
    {
        this.strategy = _strategy;
    }

    public void ExecuteStrategy(List<int> data)
    {
        this.strategy.Sort(data);
    }
}