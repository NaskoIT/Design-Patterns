namespace CharacterPointSize.Models
{
    using System;

    using Flyweight.Common;

    /// <summary>
    /// The 'Flyweight' abstract class
    /// </summary>
    public abstract class Character
    {
        protected char Symbol { get; set; }

        protected int Width { get; set; }

        protected int Height { get; set; }

        public void Display(int pointSize)
        {
            Console.WriteLine(PrintMessages.PointSizePrintMessage, this.Symbol, pointSize);
        }
    }
}
