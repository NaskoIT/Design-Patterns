namespace SequenceNumbers.Contracts
{
    /// <summary>
    /// The 'Aggregate' interface
    /// </summary>
    public interface IAggregate<T>
    {
        IIterator<T> CreateIterator();
    }
}
