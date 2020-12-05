namespace SequenceNumbers.Contracts
{
    /// <summary>
    /// The 'Iterator' interface
    /// </summary>
    public interface IIterator<T>
    {
        T Current { get; }

        bool Next();
    }
}
