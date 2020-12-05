namespace ItemRent
{
    /// <summary>
    ///  The 'Decorator' abstract class
    /// </summary>
    internal abstract class ItemDecorator : LibraryItem
    {
        protected ItemDecorator(LibraryItem libraryItem)
        {
            LibraryItem = libraryItem;
        }

        protected LibraryItem LibraryItem { get; private set; }

        public override void Display() => LibraryItem.Display();
    }
}
