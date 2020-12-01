namespace DocumentTypes.Documents
{
    using System.Collections.Generic;
    using DocumentTypes.Pages;

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
