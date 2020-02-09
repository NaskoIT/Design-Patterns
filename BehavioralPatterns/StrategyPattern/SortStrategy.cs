using System.Collections.Generic;

namespace StrategyPattern
{
    public abstract class SortStrategy<T>
    {
        public abstract void Sort(IEnumerable<T> collection);
    }
}
