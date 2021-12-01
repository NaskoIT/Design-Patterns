namespace SequenceNumbers.Models
{
    using System.Collections.Generic;

    using SequenceNumbers.Contracts;

    /// <summary>
    /// The 'ConcreteCollection' class
    /// </summary>
    public class Sequence<T> : ISequence<T>
    {
        private readonly List<T> items = new();

        public IIterator<T> CreateIterator()
        {
            return new SequenceIterator<T>(this);
        }

        public T this[int index]
        {
            get => this.items[index];
            set => this.items[index] = value;
        }

        public int Count => this.items.Count;

        public void Add(T item)
        {
            this.items.Add(item);
        }
    }
}
