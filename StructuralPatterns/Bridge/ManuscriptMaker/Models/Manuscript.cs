namespace ManuscriptMaker.Models
{
    using ManuscriptMaker.Core;

    public abstract class Manuscript
    {
        protected Manuscript(IFormatter formatter)
        {
            Formatter = formatter;
        }

        protected IFormatter Formatter { get; private set; }

        public abstract void Print();
    }
}
