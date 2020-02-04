using FactoryMethodPattern.Pages;
using System.Collections.Generic;

namespace FactoryMethodPattern.Documents
{
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
