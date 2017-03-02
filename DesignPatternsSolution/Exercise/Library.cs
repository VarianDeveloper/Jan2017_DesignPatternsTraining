namespace Exercise
{
    public class Library
    {
        //implement Singleton to make sure only one library will exist
        private static Library instance = new Library();
        
        private Library() { }

        public static Library GetLibrary()
        {
            return instance;
        }

        //Implement Register method by utilizing RegistrationRepository (complete missing parts)
        public int Register(IRegistarable item)
        {
            // return RegistrationRepository.Register();

            //dummy, just to compile
            return RegistrationRepository.Register(item);
        }
    }
}
