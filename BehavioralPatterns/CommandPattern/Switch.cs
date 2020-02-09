using System.Collections.Generic;

namespace CommandPattern
{
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
