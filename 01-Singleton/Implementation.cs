namespace Singleton
{
    /// <summary>
    /// Singleton
    /// </summary>
    public class Logger
    {

        private static Logger? _instance;

        /// <summary>
        /// Instance
        /// </summary>
        public static Logger? Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Logger();
                }
                return _instance;
            }
        }
        /// <summary>
        /// Constructor
        /// </summary>
        protected Logger() { }

        /// <summary>
        /// Singleton Operation
        /// </summary>
        /// <param name="message"></param>
        public void Log(string message)
        {
            Console.WriteLine($"Message to log: {message}");
        }

    }
}