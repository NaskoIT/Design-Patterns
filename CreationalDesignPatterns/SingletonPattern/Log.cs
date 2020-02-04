namespace SingletonPattern
{
    /// <summary>
    ///  Singleton implementation with Double-Check Lock
    /// </summary>
    public sealed class Log
    {
        private static readonly object lockObject = new object();
        private static Log instance;

        private Log()
        {
        }
         
        public static Log Instance 
        { 
            get
            {
                if(instance == null)
                {
                    lock(lockObject)
                    {
                        if(instance == null)
                        {
                            instance = new Log();
                        }
                    }
                }
                 
                return instance;
            }
        }
    }
}
