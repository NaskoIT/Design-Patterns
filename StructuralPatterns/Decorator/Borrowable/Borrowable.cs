namespace Borrowable
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The 'ConcreteDecorator' class
    /// </summary>
    internal class Borrowable : Decorator
    {
        private readonly List<string> borrowers = new List<string>();

        public Borrowable(LibraryItem libraryItem) : base(libraryItem)
        {
        }

        public void BorrowItem(string name)
        {
            borrowers.Add(name);
            LibraryItem.CopiesCount--;
        }

        public void ReturnItem(string name)
        {
            borrowers.Remove(name);
            LibraryItem.CopiesCount++;
        }

        public override void Display()
        {
            base.Display();

            foreach (var borrower in borrowers)
            {
                Console.WriteLine($" Borrower: {borrower}");
            }
        }
    }
}
