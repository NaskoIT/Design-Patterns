using System;

namespace CommandPattern
{
    /// <summary>
    /// The 'Receiver' class
    /// </summary>
    public class Light
    {
        public void TurnOn()
        {
            Console.WriteLine("The light is on!");
        }

        public void TurnOff()
        {
            Console.WriteLine("The light is off!");
        }
    }
}
