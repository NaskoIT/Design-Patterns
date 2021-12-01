namespace ItemRent
{
    /// <summary>
    ///  The 'Decorator' abstract class
    /// </summary>
    internal abstract class LibraryItemDecorator : LibraryItem
    {
        protected LibraryItemDecorator(LibraryItem libraryItem)
        {
            LibraryItem = libraryItem;
        }

        protected LibraryItem LibraryItem { get; private set; }

        public override void Display() => LibraryItem.Display();
    }
}
