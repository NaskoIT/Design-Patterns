namespace FlyweightPattern
{
    using System;
    
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
            Console.WriteLine($"{Symbol} (point size {pointSize})");
        }
    }
}
