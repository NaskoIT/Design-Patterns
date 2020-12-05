namespace SequenceNumbers.Contracts
{
    public interface IAggregate<T>
    {
        IIterator<T> CreateIterator();
    }
}
