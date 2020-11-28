namespace SortStrategy
{
    using System;
    using System.Collections.Generic;

    public class MergeSort<T> : SortStrategy<T>
    {
        public override void Sort(IEnumerable<T> collection)
        {
            Console.WriteLine("Sort collection using MergeSort algorithm!");
        }
    }
}
