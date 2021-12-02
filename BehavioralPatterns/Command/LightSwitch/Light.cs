namespace LightSwitch
{
    using System;

    using Command.Common;

    /// <summary>
    /// The 'Receiver' class
    /// </summary>
    public class Light
    {
        public bool TurnedOn { get; set; }

        public void TurnOn()
        {
            this.TurnedOn = true;
            Console.WriteLine(PrintMessages.LightOn);
        }

        public void TurnOff()
        {
            this.TurnedOn = false;
            Console.WriteLine(PrintMessages.LightOff);
        }
    }
}
