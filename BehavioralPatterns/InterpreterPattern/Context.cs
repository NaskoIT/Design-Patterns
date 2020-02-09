namespace InterpreterPattern
{
    /// <summary>
    /// The 'Context' class
    /// </summary>
    public class Context
    {
        public Context(string input)
        {
            Input = input;
        }

        public string Input { get; set; }

        public int Output { get; set; }
    }
}