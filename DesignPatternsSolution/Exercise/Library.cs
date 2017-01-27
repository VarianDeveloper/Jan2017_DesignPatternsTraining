namespace Exercise
{
    public class Library
    {
        //implement Singleton to make sure only one library will exist
        private static Library _library;
        

        //Implement Register method by utilizing RegistrationRepository (complete missing parts)
        public int Register(IRegistarable registarable)
        {
             return RegistrationRepository.Register(registarable);
        }

        public static Library Instance { get { return _library ?? (_library = new Library()); } }
    }
}
