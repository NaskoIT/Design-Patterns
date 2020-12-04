namespace SequenceNumbers.Contracts
{
    public interface IIterator<T>
    {
        T Current { get; }

        bool Next();
    }
}
