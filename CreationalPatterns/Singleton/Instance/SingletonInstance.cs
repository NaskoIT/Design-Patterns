namespace Instance
{
    /// <summary>
    /// The 'Singleton' class
    /// </summary>
    public class SingletonInstance
    {
        // eager loading
        //private readonly Singleton instance = new Singleton();
        private static SingletonInstance instance;

        public static SingletonInstance GetInstance()
        {
            if (instance == null)
            {
                instance = new SingletonInstance();
            }
            return instance;
        }
    }
}
