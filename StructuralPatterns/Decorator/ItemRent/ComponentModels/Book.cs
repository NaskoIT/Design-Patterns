namespace ItemRent
{
    using System;
    using System.Text;

    using Decorator.Common;

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
            var sb = new StringBuilder();

            sb.AppendFormat(PrintMessages.Book);
            sb.AppendFormat(PrintMessages.Template, Constants.DisplayAuthor, this.author);
            sb.AppendFormat(PrintMessages.Template, Constants.DisplayTitle, this.title);
            sb.AppendFormat(PrintMessages.Template, Constants.DisplayCopies, base.CopiesCount);

            string result = sb.ToString().TrimEnd();

            Console.WriteLine(result);

        }
    }
}
