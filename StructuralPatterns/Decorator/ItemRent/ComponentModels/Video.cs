namespace ItemRent
{
    using System;
    using System.Text;

    using Decorator.Common;

    /// <summary>
    /// The 'ConcreteComponent' class
    /// </summary>
    internal class Video : LibraryItem
    {
        private readonly string director;
        private readonly string title;
        private readonly int playTime;

        public Video(string director, string title, int playTime, int copiesCount)
        {
            this.director = director;
            this.title = title;
            this.playTime = playTime;
            base.CopiesCount = copiesCount;
        }

        public override void Display()
        {
            var sb = new StringBuilder();

            sb.AppendFormat(PrintMessages.Video);
            sb.AppendFormat(PrintMessages.Template, Constants.DisplayDirector, this.director);
            sb.AppendFormat(PrintMessages.Template, Constants.DisplayTitle, this.title);
            sb.AppendFormat(PrintMessages.Template, Constants.DisplayCopies, base.CopiesCount);
            sb.AppendFormat(PrintMessages.Template, Constants.DisplayPlayTime, this.playTime);

            string result = sb.ToString().TrimEnd();

            Console.WriteLine(result);
        }
    }
}
