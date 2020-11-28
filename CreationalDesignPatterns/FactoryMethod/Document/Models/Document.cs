namespace Document.Documents
{
    using System.Collections.Generic;
    using global::Document.Pages;

    public abstract class Document
    {
        public List<Page> Pages { get; }

        public Document()
        {
            Pages = new List<Page>();
            CreatePages();
        }

        public abstract void CreatePages();
    }
}
