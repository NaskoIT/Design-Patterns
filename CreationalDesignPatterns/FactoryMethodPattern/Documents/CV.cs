using FactoryMethodPattern.Pages;

namespace FactoryMethodPattern.Documents
{
    public class CV : Document
    {
        public override void CreatePages()
        {
            base.Pages.Add(new BioPage());
            base.Pages.Add(new SkillsPage());
        }
    }
}
