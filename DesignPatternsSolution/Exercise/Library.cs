namespace Exercise
{
    public class Library
    {
        //implement Singleton to make sure only one library will exist
        static Library instance = new Library();

        private Library()
        {
            //nothing needed here
        }

        public static Library getInstance()
        {
            return instance;
        }
        

        //Implement Register method by utilizing RegistrationRepository (complete missing parts)
        public int Register(LibObject libObject)
        {
            return RegistrationRepository.Register(libObject);
        }
    }
}
