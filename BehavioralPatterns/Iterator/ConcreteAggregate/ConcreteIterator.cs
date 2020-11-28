namespace ConcreteAggregate
{
    using System;

    public class ConcreteIterator<T> : IIterator<T>
    {
        private readonly ConcreteAggregate<T> aggregate;
        private int index;

        public ConcreteIterator(ConcreteAggregate<T> aggregate)
        {
            this.aggregate = aggregate;
            index = -1;
        }

        public T Current
        {
            get
            {
                if (index < aggregate.Count)
                {
                    return aggregate[index];
                }
                else
                {
                    throw new InvalidOperationException();
                }
            }
        }

        public bool Next()
        {
            index++;
            return index < aggregate.Count;
        }
    }
}
