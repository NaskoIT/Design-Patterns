namespace SortStrategy
{
    using System.Collections.Generic;

    public abstract class SortStrategy<T>
    {
        public abstract void Sort(IEnumerable<T> collection);
    }
}
