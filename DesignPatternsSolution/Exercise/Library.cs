namespace Exercise
{
    public class Library
    {

        static Library _library = new Library();

        //implement Singleton to make sure only one library will exist
        private Library()
        {}

        public static Library GetLibrary() { return _library; }


        //Implement Register method by utilizing RegistrationRepository (complete missing parts)
        public int Register(IRegistarable registarable)
        {
            return RegistrationRepository.Register(registarable);

           
        }
    }
}
