namespace Exercise
{
    public class Library
    {
        //implement Singleton to make sure only one library will exist
        static Library instance = new Library();
        
        private Library() { }

        public static Library getInstance() { return instance; }

        //Implement Register method by utilizing RegistrationRepository (complete missing parts)
        public int Register(IRegistarable registerable)
        {
            return RegistrationRepository.Register(registerable);
        }
    }
}
