namespace ManuscriptMaker.AbstractionModels
{
    using ManuscriptMaker.ImplementatorModels;

    /// <summary>
    /// The 'Abstraction' class
    /// </summary>
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
