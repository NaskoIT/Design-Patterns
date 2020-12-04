namespace SequenceNumbers.Models
{
    using System.Collections.Generic;

    using SequenceNumbers.Contracts;

    public class ConcreteAggregate<T> : IAggregate<T>
    {
        private readonly List<T> items = new List<T>();

        public IIterator<T> CreateIterator()
        {
            return new ConcreteIterator<T>(this);
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
