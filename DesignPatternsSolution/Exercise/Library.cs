namespace Exercise
{
    public class Library
    {
        private static Library instance;

        //implement Singleton to make sure only one library will exist
        public static Library getInstance()
        {
            if (instance == null)
            {
                instance = new Library();
            }
            return instance;
        }

        private Library() {}
        

        //Implement Register method by utilizing RegistrationRepository (complete missing parts)
        public int Register(IRegistarable registerable)
        {
            return RegistrationRepository.Register(registerable);
        }
    }
}
