namespace LightSwitch
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Commands (ON/OFF) : ");
            string command = Console.ReadLine();

            Light lamp = new Light();
            ICommand switchUp = new FlipUpCommand(lamp);
            ICommand switchDown = new FlipDownCommand(lamp);

            Switch s = new Switch();

            if (command == "ON")
            {
                s.AddCommand(switchUp);
                s.ExecuteCommand(switchUp);
            }
            else if (command == "OFF")
            {
                s.AddCommand(switchDown);
                s.ExecuteCommand(switchDown);
            }
            else
            {
                Console.WriteLine("Command \"ON\" or \"OFF\" is required.");
            }
        }
    }
}
