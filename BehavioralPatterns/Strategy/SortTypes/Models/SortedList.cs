namespace SortTypes.Models
{
    using System.Collections.Generic;

    /// <summary>
    /// The 'Context' class
    /// </summary>
    public class SortedList<T>
    {
        private readonly List<T> items;

        public SortedList()
        {
            this.items = new List<T>();
        }

        public void Sort(SortStrategy<T> sortStrategy)
        {
            sortStrategy.Sort(this.items);
        }
    }
}
