namespace SequenceNumbers.Models
{
    using System;

    using SequenceNumbers.Contracts;

    /// <summary>
    /// The 'ConcreteIterator' class
    /// </summary>
    public class SequenceIterator<T> : IIterator<T>
    {
        private readonly Sequence<T> aggregate;
        private int index;

        public SequenceIterator(Sequence<T> aggregate)
        {
            this.aggregate = aggregate;
            this.index = -1;
        }

        public T Current
        {
            get
            {
                if (this.index < this.aggregate.Count)
                {
                    return this.aggregate[index];
                }
                else
                {
                    throw new InvalidOperationException();
                }
            }
        }

        public bool Next()
        {
            this.index++;
            return this.index < this.aggregate.Count;
        }
    }
}
