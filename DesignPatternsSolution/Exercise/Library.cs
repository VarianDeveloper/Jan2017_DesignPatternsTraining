namespace Exercise
{
    public class Library
    {
        private BookBorrowable bbook;
        private int numberOfBooks = 0;

        static Library instance = new Library();
        //implement Singleton to make sure only one library will exist
        private Library() { }


        public static Library getInstance()
        {
            return instance;
        }


        //Implement Register method by utilizing RegistrationRepository (complete missing parts)
        public int Register(IRegistarable obj)
        {


            return RegistrationRepository.Register(obj);

            //dummy, just to compile
            //return 0;
        }

    }
}
