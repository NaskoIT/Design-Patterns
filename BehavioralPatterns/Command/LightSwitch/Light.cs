namespace LightSwitch
{
    using System;

    using Command.Common;

    /// <summary>
    /// The 'Receiver' class
    /// </summary>
    public class Light
    {
        public void TurnOn()
        {
            Console.WriteLine(PrintMessages.LightOn);
        }

        public void TurnOff()
        {
            Console.WriteLine(PrintMessages.LightOff);
        }
    }
}
