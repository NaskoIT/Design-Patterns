namespace DecoratorPattern
{
    /// <summary>
    ///  The 'Decorator' abstract class
    /// </summary>
    internal abstract class Decorator : LibraryItem
    {
        protected Decorator(LibraryItem libraryItem)
        {
            LibraryItem = libraryItem;
        }

        protected LibraryItem LibraryItem { get; private set; }

        public override void Display()
        {
            LibraryItem.Display();
        }
    }
}
