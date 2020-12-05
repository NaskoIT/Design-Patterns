namespace SortTypes.Models
{
    using System.Collections.Generic;

    /// <summary>
    /// The 'Strategy' abstract class
    /// </summary>
    public abstract class SortStrategy<T>
    {
        public abstract void Sort(IEnumerable<T> collection);
    }
}
