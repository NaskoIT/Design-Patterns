namespace ItemRent
{
    using System;
    using System.Collections.Generic;

    using Decorator.Common;

    /// <summary>
    /// The 'ConcreteDecorator' class
    /// </summary>
    internal class BorrowableLibraryItem : LibraryItemDecorator
    {
        private readonly List<string> borrowers = new();

        public BorrowableLibraryItem(LibraryItem libraryItem) 
            : base(libraryItem)
        {
        }

        public void BorrowItem(string name)
        {
            if(LibraryItem.CopiesCount == 0)
            {
                throw new InvalidOperationException(ErrorMessages.NotEnoughCopies);
            }

            this.borrowers.Add(name);
            LibraryItem.CopiesCount--;
        }

        public void ReturnItem(string name)
        {
            this.borrowers.Remove(name);
            LibraryItem.CopiesCount++;
        }

        public override void Display()
        {
            base.Display();

            foreach (var borrower in this.borrowers)
            {
                Console.WriteLine(PrintMessages.Borrower, borrower);
            }
        }
    }
}
