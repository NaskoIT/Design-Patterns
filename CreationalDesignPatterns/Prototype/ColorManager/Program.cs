namespace ColorManager
{
    using System;

    using Prototype.Common;

    public class Program
    {
        public static void Main()
        {
            Color color = new Color(10, 20, 30);
            Color otherColor = color.Clone() as Color;

            ColorManager colorManager = new ColorManager();

            colorManager[Constants.ColorRed] = new Color(255, 0, 0);
            colorManager[Constants.ColorGreen] = new Color(0, 255, 0);
            colorManager[Constants.ColorBlue] = new Color(0, 0, 255);

            var angryColor = colorManager[Constants.ColorRed].Clone() as Color;
            var relaxColor = colorManager[Constants.ColorGreen].Clone() as Color;
            var peaceColor = colorManager[Constants.ColorBlue].Clone() as Color;

            Console.WriteLine(angryColor);
            Console.WriteLine(relaxColor);
            Console.WriteLine(peaceColor);
        }
    }
}
