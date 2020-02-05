namespace IteratorPattern
{
    public interface IIterator<T>
    {
        T Current { get; }

        bool Next();
    }
}
