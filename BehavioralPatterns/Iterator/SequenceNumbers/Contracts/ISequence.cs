namespace SequenceNumbers.Contracts
{
    /// <summary>
    /// The 'Collection' interface
    /// </summary>
    public interface ISequence<T>
    {
        IIterator<T> CreateIterator();
    }
}
