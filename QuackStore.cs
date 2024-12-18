namespace DuckReunion
{
    public class QuackStore
    {
        private static QuackStore instance;
        private static readonly object instanceLock = new object();
        public static QuackStore Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new QuackStore();
                    }
                    return instance;
                }
            }
        }
        private int number;
        public int NumberOfQuacks
        {
            get
            {
                return number;
            }
        }
        public void Increment()
        {
            number++;
        }
    }
}
