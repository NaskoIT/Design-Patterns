namespace LightSwitch
{
    /// <summary>
    /// The Command for turning on the light - ConcreteCommand #1 
    /// </summary>
    public class FlipUpCommand : ICommand
    {
        private readonly Light light;

        public FlipUpCommand(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            light.TurnOn();
        }
    }
}
