namespace Exercise
{
    public class Library
    {
        //implement Singleton to make sure only one library will exist
        private static Library _library;

        private Library() {}

        //Implement Register method by utilizing RegistrationRepository (complete missing parts)
        public int Register(IRegistrable registrableItem)
        {
            return RegistrationRepository.Register(registrableItem);
        }

        public static Library GetInstance()
        {
            return _library ?? (_library = new Library());
        }
    }
}
