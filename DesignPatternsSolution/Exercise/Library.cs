namespace Exercise
{
    public class Library
    {
        //implement Singleton to make sure only one library will exist
        private static Library _instance = new Library();

        private Library()
        {
        }

        public static Library GetInstance()
        {
            return _instance;
        }        

        //Implement Register method by utilizing RegistrationRepository (complete missing parts)
        public int Register(IRegistarable registrable)
        {
            return RegistrationRepository.Register(registrable);
        }
    }
}
