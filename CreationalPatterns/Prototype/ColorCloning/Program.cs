namespace ColorCloning
{
    using System;

    using ColorCloning.Models;
    using Prototype.Common;

    public class Program
    {
        public static void Main()
        {
            Color color = new(10, 20, 30);
            Color otherColor = color.Clone() as Color;

            Console.WriteLine($"Are the cloned and original color with equal references: {color == otherColor}");

            ColorManager colorManager = new();

            colorManager[Constants.RedColor] = new Color(255, 0, 0);
            colorManager[Constants.GeenColor] = new Color(0, 255, 0);
            colorManager[Constants.BlueColor] = new Color(0, 0, 255);

            var angryColor = colorManager[Constants.RedColor].Clone() as Color;
            var relaxColor = colorManager[Constants.GeenColor].Clone() as Color;
            var peaceColor = colorManager[Constants.BlueColor].Clone() as Color;

            Console.WriteLine(angryColor);
            Console.WriteLine(relaxColor);
            Console.WriteLine(peaceColor);
        }
    }
}
