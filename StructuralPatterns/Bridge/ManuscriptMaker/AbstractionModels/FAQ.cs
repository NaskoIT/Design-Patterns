namespace ManuscriptMaker.AbstractionModels
{
    using System;
    using System.Collections.Generic;

    using ManuscriptMaker.ImplementatorModels;

    /// <summary>
    /// The 'RefinedAbstraction' class
    /// </summary>
    public class FAQ : Manuscript
    {
        public FAQ(IFormatter formatter) : base(formatter)
        {
            Questions = new Dictionary<string, string>();
        }

        public string Title { get; set; }

        public Dictionary<string, string> Questions { get; set; }

        public override void Print()
        {
            Console.WriteLine(Formatter.Format(nameof(Title), Title));

            foreach (var question in Questions)
            {
                Console.WriteLine(Formatter.Format($"  Question", question.Key));
                Console.WriteLine(Formatter.Format($"  Answer", question.Value));
            }

            Console.WriteLine();
        }
    }
}
