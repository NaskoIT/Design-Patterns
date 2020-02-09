namespace VisitorPattern
{
    /// <summary>
    /// The 'Visitor' interface
    /// </summary>
    public interface IVisitor
    {
        void Visit(Element element);
    }
}