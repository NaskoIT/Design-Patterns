using System.Collections.Generic;

namespace StrategyPattern
{
    public class SortedList<T> 
    {
        private readonly List<T> items;

        public SortedList()
        {
            items = new List<T>();
        }

        public void Sort(SortStrategy<T> sortStrategy)
        {
            sortStrategy.Sort(items);
        }
    }
}
