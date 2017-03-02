namespace Exercise
{
    public class Library
    {
        //implement Singleton to make sure only one library will exist

        static Library library = new Library();

        private Library() { }

        public static Library getLibrary() { return library; }

        //Implement Register method by utilizing RegistrationRepository (complete missing parts)
        public int Register()
        {
            // return RegistrationRepository.Register();

            //dummy, just to compile
            return 0;
        }
    }
}
