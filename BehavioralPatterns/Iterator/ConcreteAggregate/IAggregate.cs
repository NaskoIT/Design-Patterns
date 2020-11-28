namespace IteratorPattern
{
    public interface IAggregate<T>
    {
        IIterator<T> CreateIterator();
    }
}
