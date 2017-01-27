namespace Exercise
{
    public class Library
    {
        //implement Singleton to make sure only one library will exist
        private static Library _library;
        

        //Implement Register method by utilizing RegistrationRepository (complete missing parts)
        public int Register()
        {
            // return RegistrationRepository.Register();

            //dummy, just to compile
            return 0;
        }

        public static Library Instance { get { return _library ?? (_library = new Library()); } }
    }
}
