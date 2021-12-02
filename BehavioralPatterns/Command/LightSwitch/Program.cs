namespace LightSwitch
{
    using System;

    using Command.Common;

    public class Program
    {
        public static void Main()
        {
            Console.WriteLine(PrintMessages.EnterCommands);
            string command = Console.ReadLine().ToUpper();

            Light lamp = new();
            ICommand switchUp = new FlipUpCommand(lamp);
            ICommand switchDown = new FlipDownCommand(lamp);

            Switch s = new();

            if (command == Constants.DisplayOn)
            {
                s.AddCommand(switchUp);
                s.ExecuteCommand(switchUp);
            }
            else if (command == Constants.DisplayOff)
            {
                s.AddCommand(switchDown);
                s.ExecuteCommand(switchDown);
            }
            else
            {
                Console.WriteLine(PrintMessages.RequiredCommand);
            }
        }
    }
}
