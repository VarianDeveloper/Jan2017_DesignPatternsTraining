namespace Exercise
{
    public class Library
    {
        //implement Singleton to make sure only one library will exist
        private static Library libraryInstance = new Library();

        private Library() { }

        public static Library getInstance()
        {
            return libraryInstance;
        }

        //Implement Register method by utilizing RegistrationRepository (complete missing parts)
        public int Register()
        {
            return RegistrationRepository.Register(new Book("andrew", "title",2017, 4));
        }
    }
}
