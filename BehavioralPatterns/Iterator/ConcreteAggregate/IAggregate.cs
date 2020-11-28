namespace ConcreteAggregate
{
    public interface IAggregate<T>
    {
        IIterator<T> CreateIterator();
    }
}
