namespace Exercise
{
    public class Library
    {
        private static readonly Library Instance = new Library();

        private Library()
        {
        }

        public static Library GetInstance()
        {
            return Instance;
        }

        public int Register()
        {
            return 0;
        }
    }
}
