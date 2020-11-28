namespace CommandPattern
{
    using System.Collections.Generic;

    /// <summary>
    /// The 'Invoker' class
    /// </summary>
    public class Switch
    {
        private List<ICommand> commands = new List<ICommand>();

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
