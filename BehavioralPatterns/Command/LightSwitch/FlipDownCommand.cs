namespace LightSwitch
{
    /// <summary>
    /// The Command for turning off the light - ConcreteCommand #2 
    /// </summary>
    public class FlipDownCommand : ICommand
    {
        private readonly Light light;

        public FlipDownCommand(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            light.TurnOff();
        }
    }
}
