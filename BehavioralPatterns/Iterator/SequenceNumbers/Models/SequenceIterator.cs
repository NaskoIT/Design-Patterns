namespace SequenceNumbers.Models
{
    using System;

    using SequenceNumbers.Contracts;

    /// <summary>
    /// The 'ConcreteIterator' class
    /// </summary>
    public class SequenceIterator<T> : IIterator<T>
    {
        private readonly Sequence<T> sequence;
        private int index;

        public SequenceIterator(Sequence<T> sequence)
        {
            this.sequence = sequence;
            this.index = -1;
        }

        public T Current
        {
            get
            {
                if (this.index < this.sequence.Count)
                {
                    return this.sequence[index];
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
            return this.index < this.sequence.Count;
        }
    }
}
