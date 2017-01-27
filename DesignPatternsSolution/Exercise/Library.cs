namespace Exercise
{
    public class Library
    {
        private static Library library = new Library();

        private Library() { }

        public static Library getInstance()
        {
            return library;
        }

        //Implement Register method by utilizing RegistrationRepository (complete missing parts)
        public int Register()
        {
            // return RegistrationRepository.Register();

            //dummy, just to compile
            return 0;
        }
    }
}
