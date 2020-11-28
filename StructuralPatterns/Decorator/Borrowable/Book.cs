namespace DecoratorPattern
{
    using System;

    /// <summary>
    /// The 'ConcreteComponent' class
    /// </summary>
    internal class Book : LibraryItem
    {
        private readonly string author;
        private readonly string title;

        public Book(string author, string title, int copiesCount)
        {
            this.author = author;
            this.title = title;
            CopiesCount = copiesCount;
        }

        public override void Display()
        {
            Console.WriteLine("\nBook --------- ");
            Console.WriteLine($" Author: {author}");
            Console.WriteLine($" Title: {title}");
            Console.WriteLine($" # Copies: {CopiesCount}");
        }
    }
}
