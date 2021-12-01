namespace DocumentTypes.CreatorModels
{
    using System.Collections.Generic;

    using DocumentTypes.ProductModels;

    /// <summary>
    /// The 'Creator' abstract class
    /// </summary>
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
