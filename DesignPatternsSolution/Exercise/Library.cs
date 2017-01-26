namespace Exercise
{
    public class Library
    {
        //implement Singleton to make sure only one library will exist
        static Library library = new Library();


        private Library() { }

        public static Library getLibrary() { return library; }
        

        //Implement Register method by utilizing RegistrationRepository (complete missing parts)
        public int Register(IRegistarable register)
        {
            return RegistrationRepository.Register(register);
        }
    }
}
