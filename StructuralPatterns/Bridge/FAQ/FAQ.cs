namespace FAQ
{
    using System;
    using System.Collections.Generic;

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
