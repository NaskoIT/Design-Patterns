namespace BridgePattern
{
    using System;

    public class Book : Manuscript
    {
        public Book(IFormatter formatter) : base(formatter)
        {
        }

        public string Title { get; set; }

        public string Author { get; set; }

        public string Text { get; set; }

        public override void Print()
        {
            Console.WriteLine(Formatter.Format(nameof(Title), Title));
            Console.WriteLine(Formatter.Format(nameof(Author), Author));
            Console.WriteLine(Formatter.Format(nameof(Text), Text));
            Console.WriteLine();
        }
    }
}
