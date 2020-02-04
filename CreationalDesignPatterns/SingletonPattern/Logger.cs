using System;

namespace SingletonPattern
{
    public static class Logger
    {
        static Logger()
        {
            Instance = new InnerLogger();
        }

        public static InnerLogger Instance { get; private set; }

        public class InnerLogger
        {
            internal InnerLogger()
            {
            }

            public void Log(string message)
            {
                Console.WriteLine(message);
            }
        }
    }
}
