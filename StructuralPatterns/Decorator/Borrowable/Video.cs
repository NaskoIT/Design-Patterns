namespace Borrowable
{
    using System;
   
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
            CopiesCount = copiesCount;
        }

        public override void Display()
        {
            Console.WriteLine("\nVideo ---------- ");
            Console.WriteLine($" Director: {director}");
            Console.WriteLine($" Title: {title}");
            Console.WriteLine($" # Copies: {CopiesCount}");
            Console.WriteLine($" PlayTime: {playTime}");
        }
    }
}
