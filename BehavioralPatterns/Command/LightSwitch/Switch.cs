namespace LightSwitch
{
    using System.Collections.Generic;

    /// <summary>
    /// The 'Invoker' class
    /// </summary>
    public class Switch
    {
        private readonly List<ICommand> commands = new();

        public void AddCommand(ICommand command)
        {
            commands.Add(command);
        }

        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
        }
    }
}
